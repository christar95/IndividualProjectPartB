namespace IndividualProjectPartB.Migrations
{
    using IndividualProjectPartB.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IndividualProjectPartB.MyDatabase.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(IndividualProjectPartB.MyDatabase.ApplicationContext context)
        {
            #region Seeding Students
            Student s1=new Student() {FirstName="Christos",LastName="Arampatzis",DateOfBirth=new DateTime(1995,6,1).Date,TuitionFees=2500};
            Student s2=new Student() {FirstName="Dimitris",LastName="Papadopoulos",DateOfBirth=new DateTime(1990,5,15).Date,TuitionFees=1850};
            Student s3=new Student() {FirstName="Giannis",LastName="Sofianos",DateOfBirth=new DateTime(2000,9,28).Date,TuitionFees=1546};
            Student s4=new Student() {FirstName="Stefanos",LastName="Akritidis",DateOfBirth=new DateTime(1981,8,10).Date,TuitionFees=3000};
            Student s5=new Student() {FirstName="Iraklis",LastName="Xarilaou",DateOfBirth=new DateTime(1990,4,12).Date,TuitionFees=2000};
            Student s6=new Student() {FirstName="Thomas",LastName="Mpismpikis",DateOfBirth=new DateTime(1975,1,19).Date,TuitionFees=3152};
            Student s7=new Student() {FirstName="Alexandros",LastName="Charalampidis",DateOfBirth=new DateTime(1987,6,28).Date,TuitionFees=2120};
            Student s8=new Student() {FirstName="Vaggelis",LastName="Papandreou",DateOfBirth=new DateTime(1998,7,30).Date,TuitionFees=3400};
            Student s9=new Student() {FirstName="Nikos",LastName="Grigoriou",DateOfBirth=new DateTime(1960,2,1).Date,TuitionFees=2300};
            Student s10=new Student() {FirstName="Thanasis",LastName="Panagoulias",DateOfBirth=new DateTime(1972,3,8).Date,TuitionFees=3700};
            Student s11=new Student() {FirstName="Maria",LastName="Avramidou",DateOfBirth=new DateTime(1980,1,15).Date,TuitionFees=4000};
            Student s12=new Student() {FirstName="Sofia",LastName="Vasileiou",DateOfBirth=new DateTime(1991,3,9).Date,TuitionFees=2800};
            Student s13=new Student() {FirstName="Dimitra",LastName="Merkouri",DateOfBirth=new DateTime(1958,3,22).Date,TuitionFees=3300};
            Student s14=new Student() {FirstName="Christina",LastName="Asimakopoulou",DateOfBirth=new DateTime(1994,4,25).Date,TuitionFees=2200};
            Student s15=new Student() {FirstName="Ioanna",LastName="Eleftheriou",DateOfBirth=new DateTime(1999,5,31).Date,TuitionFees=1900};
            Student s16=new Student() {FirstName="Elpida",LastName="Papadopoulou",DateOfBirth=new DateTime(1995,2,28).Date,TuitionFees=2670};
            Student s17=new Student() {FirstName="Evangelia",LastName="Tsakona",DateOfBirth=new DateTime(1992,9,7).Date,TuitionFees=3450};
            Student s18=new Student() {FirstName="Despoina",LastName="Stilianou",DateOfBirth=new DateTime(1986,4,1).Date,TuitionFees=4100};
            Student s19=new Student() {FirstName="Kyriaki",LastName="Kokkinou",DateOfBirth=new DateTime(1977,10,5).Date,TuitionFees=4300};
            Student s20=new Student() {FirstName="Kaliopi",LastName="Avgerinou",DateOfBirth=new DateTime(1972,11,16).Date,TuitionFees=3800};
            context.Students.AddOrUpdate(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20);
            context.SaveChanges();
            #endregion
            #region Seeding Trainers
            Trainer t1 = new Trainer() { FirstName = "Ektoras", LastName = "Gatsos", Subject = "C#" };
            Trainer t2 = new Trainer() { FirstName = "Giwrgos", LastName = "Pasparakis", Subject = "Java" };
            Trainer t3 = new Trainer() { FirstName = "Panagiotis", LastName = "Mpozas", Subject = "PHP" };
            Trainer t4 = new Trainer() { FirstName = "Lakis", LastName = "Manousakis", Subject = "Javascript" };
            Trainer t5 = new Trainer() { FirstName = "Takis", LastName = "Panagoulias", Subject = "C++" };
            Trainer t6 = new Trainer() { FirstName = "Ektoras", LastName = "Gatsos", Subject = "Python" };
            Trainer t7 = new Trainer() { FirstName = "Ektoras", LastName = "Gatsos", Subject = "CSS" };
            Trainer t8 = new Trainer() { FirstName = "Ektoras", LastName = "Gatsos", Subject = "HTML" };
            Trainer t9 = new Trainer() { FirstName = "Ektoras", LastName = "Gatsos", Subject = "Unity" };
            Trainer t10 = new Trainer() { FirstName = "Ektoras", LastName = "Gatsos", Subject = "Visual Basic" };
            context.Trainers.AddOrUpdate(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
            context.SaveChanges();
            #endregion
            #region Seeding Assignments
            Assignment a1 = new Assignment() { Title = "Calculator", Description = "Generate a calculator", SubmissionDate = new DateTime(2022, 6, 20).Date, OralMark = 80, TotalMark = 60 };
            Assignment a2 = new Assignment() { Title = "Map", Description = "Make a map of an area", SubmissionDate = new DateTime(2022, 6, 25).Date, OralMark = 80, TotalMark = 70 };
            Assignment a3 = new Assignment() { Title = "E-Banking", Description = "Make an e-banking app", SubmissionDate = new DateTime(2022, 6, 30).Date, OralMark = 70, TotalMark = 55 };
            Assignment a4 = new Assignment() { Title = "Screensaver", Description = "Generate a screensaver setter", SubmissionDate = new DateTime(2022, 6, 20).Date, OralMark = 60, TotalMark = 50 };
            Assignment a5 = new Assignment() { Title = "Canvas", Description = "Generate a painting app", SubmissionDate = new DateTime(2022, 6, 20).Date, OralMark = 80, TotalMark = 90 };
            Assignment a6 = new Assignment() { Title = "Search", Description = "Generate a search engine", SubmissionDate = new DateTime(2022, 6, 20).Date, OralMark = 75, TotalMark = 70 };
            Assignment a7 = new Assignment() { Title = "Playlist", Description = "Make random song playlists", SubmissionDate = new DateTime(2022, 6, 20).Date, OralMark = 62, TotalMark = 65 };
            Assignment a8 = new Assignment() { Title = "School", Description = "Generate a school database", SubmissionDate = new DateTime(2022, 6, 20).Date, OralMark = 50, TotalMark = 40 };
            Assignment a9 = new Assignment() { Title = "Battery", Description = "Generate a battery health indicator", SubmissionDate = new DateTime(2022, 6, 20).Date, OralMark = 55, TotalMark = 50 };
            Assignment a10 = new Assignment() { Title = "Cart", Description = "Generate a shopping cart list", SubmissionDate = new DateTime(2022, 6, 20).Date, OralMark = 45, TotalMark = 35 };
            Assignment a11 = new Assignment() { Title = "Favorites", Description = "Make a favorites list on a browser", SubmissionDate = new DateTime(2022, 6, 20).Date, OralMark = 56, TotalMark = 48 };
            Assignment a12 = new Assignment() { Title = "Engine", Description = "Generate a car engine design", SubmissionDate = new DateTime(2022, 6, 20).Date, OralMark = 78, TotalMark = 75 };
            Assignment a13 = new Assignment() { Title = "Editor", Description = "Generate a video editor", SubmissionDate = new DateTime(2022, 6, 20).Date, OralMark = 86, TotalMark = 80 };
            Assignment a14 = new Assignment() { Title = "Stream", Description = "Generate a video stream", SubmissionDate = new DateTime(2022, 6, 20).Date, OralMark = 92, TotalMark = 85 };
            Assignment a15 = new Assignment() { Title = "Timer", Description = "Generate a timer", SubmissionDate = new DateTime(2022, 6, 20).Date, OralMark = 40, TotalMark = 45 };
            Assignment a16 = new Assignment() { Title = "Heartbeat", Description = "Generate a heartbeat counter", SubmissionDate = new DateTime(2022, 6, 20).Date, OralMark = 55, TotalMark = 42 };
            Assignment a17 = new Assignment() { Title = "Ebooks", Description = "Generate an ebbok library with reader", SubmissionDate = new DateTime(2022, 6, 20).Date, OralMark = 65, TotalMark = 54 };
            Assignment a18 = new Assignment() { Title = "Notes", Description = "Generate a virtual post-it note", SubmissionDate = new DateTime(2022, 6, 20).Date, OralMark = 95, TotalMark = 78 };
            Assignment a19 = new Assignment() { Title = "Flight", Description = "Generate a flight ticket finder", SubmissionDate = new DateTime(2022, 6, 20).Date, OralMark = 63, TotalMark = 59 };
            Assignment a20 = new Assignment() { Title = "Adblocker", Description = "Generate an adblocker", SubmissionDate = new DateTime(2022, 6, 20).Date, OralMark = 90, TotalMark = 82 };
            context.Assignments.AddOrUpdate(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20);
            context.SaveChanges();
            #endregion
            #region Seeding Courses
            Course c1 = new Course() { Title = "C#", Stream = "CB16", Type = Enums.Type.Part_Time, Start_Date = new DateTime(2020, 2, 28).Date, End_Date = new DateTime(2020, 9, 27).Date };
            Course c2 = new Course() { Title = "Java", Stream = "CB16", Type = Enums.Type.Part_Time, Start_Date = new DateTime(2020, 2, 28).Date, End_Date = new DateTime(2020, 9, 27).Date };
            Course c3 = new Course() { Title = "Python", Stream = "CB16", Type = Enums.Type.Full_Time, Start_Date = new DateTime(2020, 2, 28).Date, End_Date = new DateTime(2020, 5, 28).Date };
            Course c4 = new Course() { Title = "Javascript", Stream = "CB16", Type = Enums.Type.Full_Time, Start_Date = new DateTime(2020, 2, 28).Date, End_Date = new DateTime(2020, 5, 28).Date };
            Course c5 = new Course() { Title = "C++", Stream = "CB16", Type = Enums.Type.Full_Time, Start_Date = new DateTime(2020, 2, 28).Date, End_Date = new DateTime(2020, 5, 28).Date };
            context.Courses.AddOrUpdate(c1, c2, c3, c4, c5);
            context.SaveChanges();
            #endregion
            #region Populate courses
            c1.Trainers.Add(t1);
            c1.Trainers.Add(t3);
            c1.Trainers.Add(t6);
            c2.Trainers.Add(t2);
            c2.Trainers.Add(t4);
            c2.Trainers.Add(t5);
            c3.Trainers.Add(t7);
            c3.Trainers.Add(t8);
            c3.Trainers.Add(t10);
            c4.Trainers.Add(t10);
            c4.Trainers.Add(t9);
            c4.Trainers.Add(t8);
            c5.Trainers.Add(t1);
            c5.Trainers.Add(t4);
            c5.Trainers.Add(t3);
            c1.Assignments.Add(a1);
            c1.Assignments.Add(a2);
            c1.Assignments.Add(a3);
            c1.Assignments.Add(a4);
            c2.Assignments.Add(a5);
            c2.Assignments.Add(a6);
            c2.Assignments.Add(a7);
            c2.Assignments.Add(a8);
            c3.Assignments.Add(a9);
            c3.Assignments.Add(a10);
            c3.Assignments.Add(a11);
            c3.Assignments.Add(a12);
            c4.Assignments.Add(a13);
            c4.Assignments.Add(a14);
            c4.Assignments.Add(a15);
            c4.Assignments.Add(a16);
            c5.Assignments.Add(a17);
            c5.Assignments.Add(a18);
            c5.Assignments.Add(a19);
            c5.Assignments.Add(a20);
            c1.Students.Add(s1);
            c1.Students.Add(s2);
            c1.Students.Add(s3);
            c1.Students.Add(s4);
            c2.Students.Add(s5);
            c2.Students.Add(s6);
            c2.Students.Add(s7);
            c2.Students.Add(s8);
            c3.Students.Add(s9);
            c3.Students.Add(s10);
            c3.Students.Add(s11);
            c3.Students.Add(s12);
            c4.Students.Add(s13);
            c4.Students.Add(s14);
            c4.Students.Add(s15);
            c4.Students.Add(s16);
            c5.Students.Add(s17);
            c5.Students.Add(s18);
            c5.Students.Add(s19);
            c5.Students.Add(s20);
            context.SaveChanges();
            #endregion
            #region Populate students
            s1.Assignments.Add(a1);
            s1.Courses.Add(c1);
            s2.Assignments.Add(a2);
            s2.Courses.Add(c1);
            s3.Assignments.Add(a3);
            s3.Courses.Add(c1);
            s4.Assignments.Add(a4);
            s4.Courses.Add(c1);
            s5.Assignments.Add(a5);
            s5.Courses.Add(c2);
            s6.Assignments.Add(a6);
            s6.Courses.Add(c2);
            s7.Assignments.Add(a7);
            s7.Courses.Add(c2);
            s8.Assignments.Add(a8);
            s8.Courses.Add(c2);
            s9.Assignments.Add(a9);
            s9.Courses.Add(c3);
            s10.Assignments.Add(a10);
            s10.Courses.Add(c3);
            s11.Assignments.Add(a11);
            s11.Courses.Add(c3);
            s12.Assignments.Add(a12);
            s12.Courses.Add(c3);
            s13.Assignments.Add(a13);
            s13.Courses.Add(c4);
            s14.Assignments.Add(a14);
            s14.Courses.Add(c4);
            s15.Assignments.Add(a15);
            s15.Courses.Add(c4);
            s16.Assignments.Add(a16);
            s16.Courses.Add(c4);
            s17.Assignments.Add(a17);
            s17.Courses.Add(c5);
            s18.Assignments.Add(a18);
            s18.Courses.Add(c5);
            s19.Assignments.Add(a19);
            s19.Courses.Add(c5);
            s20.Assignments.Add(a20);
            s20.Courses.Add(c5);
            context.SaveChanges();
            #endregion
            #region Populate trainers
            t1.Courses.Add(c1);
            t1.Courses.Add(c5);
            t2.Courses.Add(c2);
            t3.Courses.Add(c1);
            t3.Courses.Add(c5);
            t4.Courses.Add(c2);
            t4.Courses.Add(c5);
            t5.Courses.Add(c2);
            t6.Courses.Add(c1);
            t7.Courses.Add(c3);
            t8.Courses.Add(c3);
            t8.Courses.Add(c4);
            t9.Courses.Add(c4);
            t10.Courses.Add(c3);
            t10.Courses.Add(c4);
            context.SaveChanges();
            #endregion
            #region Populate assignments
            a1.Course=c1;
            a2.Course=c1;
            a3.Course=c1;
            a4.Course=c1;
            a5.Course=c2;
            a6.Course=c2;
            a7.Course=c2;
            a8.Course=c2;
            a9.Course=c3;
            a10.Course=c3;
            a11.Course=c3;
            a12.Course=c3;
            a13.Course=c4;
            a14.Course=c4;
            a15.Course=c4;
            a16.Course=c4;
            a17.Course=c5;
            a18.Course=c5;
            a19.Course=c5;
            a20.Course=c5;
            a1.Students.Add(s1);
            a2.Students.Add(s2);
            a3.Students.Add(s3);
            a4.Students.Add(s4);
            a5.Students.Add(s5);
            a6.Students.Add(s6);
            a7.Students.Add(s7);
            a8.Students.Add(s8);
            a9.Students.Add(s9);
            a10.Students.Add(s10);
            a11.Students.Add(s11);
            a12.Students.Add(s12);
            a13.Students.Add(s13);
            a14.Students.Add(s14);
            a15.Students.Add(s15);
            a16.Students.Add(s16);
            a17.Students.Add(s17);
            a18.Students.Add(s18);
            a19.Students.Add(s19);
            a20.Students.Add(s20);
            context.SaveChanges();
            #endregion
        }
    }
}
