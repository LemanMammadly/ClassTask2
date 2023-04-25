Student stu1 = new("Laman", "Mammadli");
Student stu2 = new("Lam", "Mammad");
Student stu3 = new("Lmn", "Mdli");
Student stu4 = new("L", "M");
Student stu5 = new("leman", "Mammad");

Student[] arr1 = new Student[4];
arr1[0] = stu1;
arr1[1] = stu2;
arr1[2] = stu3;
arr1[3] = stu4;

Group group1 = new("P137", 4, arr1);


Console.WriteLine(group1.AddStudent(stu5));
group1.GetStudents();


