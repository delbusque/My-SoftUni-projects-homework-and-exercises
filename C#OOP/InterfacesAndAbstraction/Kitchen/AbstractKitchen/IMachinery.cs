namespace AbstractKitchen
{
    internal interface IMachinery
    {
        void ListAllMachineries();

        List<string> Machineries { get; set; }
    }
}