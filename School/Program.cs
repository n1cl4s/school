var matte = new Course("Matematik", 2);
var idrott = new Course("Idrott", 3);

var anders = new Student("Anders");
var tommy = new Student("Tommy");
var niclas = new Student("Niclas");


matte.Enroll(anders); 
anders.Join(matte);
anders.Join(matte);
niclas.Join(matte);
matte.Enroll(anders);
tommy.Join(matte);
anders.Join(idrott);
niclas.Join(idrott);
anders.Leave(idrott);
tommy.Join(idrott);
matte.RollCall();
tommy.Schedule();
anders.Schedule();
System.Console.WriteLine(matte);
System.Console.WriteLine(idrott);