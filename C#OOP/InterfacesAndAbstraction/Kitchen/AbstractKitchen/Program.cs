using AbstractKitchen;

Kitchen kitchen = new Kitchen();

Waiter waiter = new Waiter() { Kitchen = kitchen };

waiter.Kitchen.OrderMeal("Pizza");

Technician tech = new Technician() { Kitchen = kitchen};

tech.Kitchen.ListAllMachineries();