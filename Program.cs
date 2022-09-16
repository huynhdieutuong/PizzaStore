using PizzaStore;

var hcmStore = new HCMStore();
hcmStore.OrderPizza(PizzaType.Cheese);

var hnStore = new HNStore();
hnStore.OrderPizza(PizzaType.Greek);

var dnStore = new DNStore();
dnStore.OrderPizza(PizzaType.Pepperoni);