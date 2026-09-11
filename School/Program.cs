var matte = new Course("Matematik", 1);

var anders = new Student("Anders");
var tommy = new Student("Tommy");
var niclas = new Student("Niclas");


matte.Enroll(anders); 
anders.Join(matte);
anders.Leave(matte);
matte.Enroll(anders);
matte.RollCall();
