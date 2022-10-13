using IndividualProjectPartB.Repositories;
using IndividualProjectPartB.Views.AssignmentView;
using IndividualProjectPartB.Views.CourseView;
using IndividualProjectPartB.Views.StudentView;
using IndividualProjectPartB.Views.TrainerView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartB
{
    public class Menu
    {
        public static void ChooseAction()
        {


            Console.WriteLine("Type the number to execute: 1.Print 2.New 3.Add");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": ActionPrint(); break;
                case "2": ActionCreate(); break;
                case "3": ActionAdd(); break;
                default:
                    Console.WriteLine("Try again");
                    break;
            }

        }

        public static void ActionPrint()
        {
            Console.WriteLine("1.All students\n2.All trainers\n3.All assignments\n4.All courses\n5.All students per course\n6.All trainers per course\n7.All assignments per course\n8.All assignments per course per student\n9.All students in more than one course");
            string action = Console.ReadLine();
            StudentRepository studentRepo = new StudentRepository();
            TrainerRepository trainerRepo = new TrainerRepository();
            var trainers = trainerRepo.GetAll();
            var students = studentRepo.GetAll();
            AssignmentRepository assignmentRepo = new AssignmentRepository();
            var assignments = assignmentRepo.GetAll();
            CourseRepository courseRepo = new CourseRepository();
            var courses = courseRepo.GetAll();
            switch (action)
            {
                case "1":
                    PrintStudent.PrintAll(students);
                    break;
                case "2":
                    PrintTrainer.PrintAll(trainers);
                    break;
                case "3":
                    PrintAssignment.PrintAll(assignments);
                    break;
                case "4":
                    PrintCourse.PrintAll(courses);
                    break;
                case "5":
                    foreach (var course in courses)
                    {
                        Console.WriteLine("Course:");
                        PrintCourse.Print(course);
                        courses = courseRepo.GetAllWithStudents();
                        Console.WriteLine("Students:");
                        foreach (var student in course.Students)
                        {
                            PrintStudent.Print(student);
                        }
                    }
                    break;
                case "6":
                    foreach (var course in courses)
                    {
                        Console.WriteLine("Course:");
                        PrintCourse.Print(course);
                        courses = courseRepo.GetAllWithTrainers();
                        Console.WriteLine("Trainers:");
                        foreach (var trainer in course.Trainers)
                        {
                            PrintTrainer.Print(trainer);
                        }
                    }
                    break;
                case "7":
                    foreach (var course in courses)
                    {
                        Console.WriteLine("Course:");
                        PrintCourse.Print(course);
                        courses = courseRepo.GetAllWithAssignments();
                        Console.WriteLine("Assignments:");
                        foreach (var assignment in course.Assignments)
                        {
                            PrintAssignment.Print(assignment);
                        }
                    }
                    break;
                case "8":
                    foreach (var course in courses)
                    {
                        Console.WriteLine("Course:");
                        PrintCourse.Print(course);
                        students = studentRepo.GetAllWithAssignments();
                        courses = courseRepo.GetAllWithStudents();
                        foreach (var student in course.Students)
                        {
                            Console.WriteLine("Student:");
                            PrintStudent.Print(student);
                            Console.WriteLine("Assignments:");
                            foreach (var assignment in student.Assignments)
                            {
                                PrintAssignment.Print(assignment);
                            }
                        }
                    }
                    break;
                case "9":
                    students = studentRepo.GetAllWithCourses();
                    foreach (var student in students)
                    {
                        if (student.Courses.Count>1)
                        {
                            PrintStudent.Print(student);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Try again");
                    break;
            }
        }

        public static void ActionCreate()
        {
            Console.WriteLine("1.Student\n2.Trainer\n3.Assignment\n4.Course");
            string action = Console.ReadLine();
            switch (action)
            {
                case "1":
                    StudentRepository studentRepo = new StudentRepository();
                    InputStudent inputStudent = new InputStudent();
                    var student = inputStudent.GetNewStudentData();
                    studentRepo.Add(student);
                    break;
                case "2":
                    TrainerRepository trainerRepo = new TrainerRepository();
                    InputTrainer inputTrainer=new InputTrainer();
                    var trainer = inputTrainer.GetNewTrainerData();
                    trainerRepo.Add(trainer);
                    break;
                case "3":
                    AssignmentRepository assignmentRepo = new AssignmentRepository();
                    InputAssignment inputAssignment = new InputAssignment();
                    var assignment = inputAssignment.GetNewAssignmentData();
                    assignmentRepo.Add(assignment);
                    break;
                case "4":
                    CourseRepository courseRepo = new CourseRepository();
                    InputCourse inputCourse = new InputCourse();
                    var course = inputCourse.GetNewCourseData();
                    courseRepo.Add(course);
                    break;
                default:
                    Console.WriteLine("Try again...");
                    break;
            }
        }

        public static void ActionAdd()
        {
            Console.WriteLine("1.Student to course\n2.Trainer to course\n3.Assignment to students in course");
            string action = Console.ReadLine();
            CourseRepository courseRepo = new CourseRepository();
            StudentRepository studentRepo = new StudentRepository();
            TrainerRepository trainerRepo = new TrainerRepository();
            AssignmentRepository assignmentRepo = new AssignmentRepository();
            var courses = courseRepo.GetAll();
            var students = studentRepo.GetAll();
            var trainers = trainerRepo.GetAll();
            var assignments=assignmentRepo.GetAll();
            switch (action)
            {
                case "1":
                    Console.WriteLine("Select course by id"); 
                    PrintCourse.PrintAll(courses);
                    int courseId = Convert.ToInt32(Console.ReadLine());
                    var course=courseRepo.Get(courseId);
                    Console.WriteLine("Choose student's id to add to course");
                    int studentId = Convert.ToInt32(Console.ReadLine());
                    var student=studentRepo.Get(studentId);
                    course.Students.Add(student);
                    student.Courses.Add(course);
                    studentRepo.Update(student);
                    courseRepo.Update(course);
                    break;
                case "2":
                    Console.WriteLine("Select course by id");
                    PrintCourse.PrintAll(courses);
                    courseId = Convert.ToInt32(Console.ReadLine());
                    course = courseRepo.Get(courseId);
                    Console.WriteLine("Choose trainer's id to add to course");
                    int trainerId = Convert.ToInt32(Console.ReadLine());
                    var trainer = trainerRepo.Get(trainerId);
                    course.Trainers.Add(trainer);
                    courseRepo.Update(course);
                    trainer.Courses.Add(course);
                    trainerRepo.Update(trainer);
                    break;
                case "3":
                    Console.WriteLine("Select course by id");
                    PrintCourse.PrintAll(courses);
                    courses = courseRepo.GetAllWithStudents();
                    courseId = Convert.ToInt32(Console.ReadLine());
                    course = courseRepo.Get(courseId);
                    Console.WriteLine("Choose assignment's id to add it to the students of the course");
                    PrintAssignment.PrintAll(assignments);
                    int assignmentId = Convert.ToInt32(Console.ReadLine());
                    var assignment = assignmentRepo.Get(assignmentId);
                    foreach (var stu in course.Students)
                    {
                        stu.Assignments.Add(assignment);
                        studentRepo.Update(stu);
                        assignment.Students.Add(stu);
                        assignmentRepo.Update(assignment);
                    }
                    break;
                default:
                    Console.WriteLine("Try again...");
                    break;
            }
        }

    }
}
