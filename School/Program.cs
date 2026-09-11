Console.Clear();

var matte = new Course("Matematik", 3);
var idrott = new Course("Idrott", 3);

var anders = new Student("Anders");
var tommy = new Student("Tommy");
var niclas = new Student("Niclas");


matte.Enroll(anders); 
anders.Join(matte);
matte.Enroll(anders);
tommy.Join(matte);
anders.Join(idrott);
matte.RollCall();
tommy.Schedule();
anders.Schedule();
System.Console.WriteLine(matte);
System.Console.WriteLine(idrott);