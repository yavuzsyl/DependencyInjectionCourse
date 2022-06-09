using TheDependencyProblem.CarExample;

Console.WriteLine();

var dieselCar = new Car(new DieselEngine());
var petrolCar = new Car(new PetrolEngine());
var testCar = new Car(new TestEngine());
//it is not dependent on engine anymore, 
//car sınıfı test edilebilir artık çünkü concrete sınıfa bağımlı değil