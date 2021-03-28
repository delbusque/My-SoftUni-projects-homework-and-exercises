using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fields)
        {
            Type classType = Type.GetType(className);

            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance
                | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(classType.FullName);

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            foreach (FieldInfo item in classFields.Where(f => fields.Contains(f.Name)))
            {
                sb.AppendLine($"{item.Name} = {item.GetValue(classInstance)}");
            }
            
            return sb.ToString().TrimEnd();
        }

        public string AnalyzeAccessModifiers(string className)
        {
            Type classType = Type.GetType(className);

            FieldInfo[] invFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static
                | BindingFlags.Public);
            MethodInfo[] invPublic = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            MethodInfo[] invNonPublic = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            foreach (var item in invFields)
            {
                sb.AppendLine($"{item.Name} must be private!");
            }

            foreach (var item in invNonPublic.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{item.Name} have to be public!");
            }

            foreach (var item in invPublic.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{item.Name} have to be private!");
            }

            return sb.ToString().TrimEnd();
        }

        public string RevealPrivateMethods(string className)
        {
            Type classType = Type.GetType(className);

            MethodInfo[] privMethods = classType.GetMethods(BindingFlags.Instance |
                BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"All Private Methods of Class: {classType.FullName}");
            sb.AppendLine($"Base Class: {classType.BaseType.Name}");

            foreach (var item in privMethods)
            {
                sb.AppendLine(item.Name);
            }
            
            return sb.ToString().TrimEnd();
        }

        public string CollectGettersAndSetters(string className)
        {
            List<MethodInfo> setters = new List<MethodInfo>();

            Type classType = Type.GetType(className);

            MethodInfo[] methods = classType.GetMethods(BindingFlags.Instance
                | BindingFlags.Public | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            foreach (var item in methods.Where(m => m.Name.StartsWith("get")))
            {
                    sb.AppendLine($"{item.Name} will return {item.ReturnType}");
            }

            foreach (var item in methods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{item.Name} will set field of {item.GetParameters().First().ParameterType}");
            }
                      
            return sb.ToString().TrimEnd();
        }

    }
}
