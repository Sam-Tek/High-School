﻿using Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Dal
{
    //Permet d'initialiser la base en utilisant le contexte
    // Contexte.Initialise();
    public static class HighSchoolContextExtension
    {
        public static void Initialize(this HighSchoolContext context, bool dropAlways = false)
        {
            if (dropAlways)
                context.Database.EnsureDeleted();

            context.Database.EnsureCreated();

            //if db has been already seeded
            if (context.Students.Any())
                return;
            #region STUDENTS
            List<Student> students = new List<Student>
            {
                new Student() { FirstName = "Douglas", LastName = "Dominic", Email = "felis@Fuscealiquam.com", BirthDate = DateTime.ParseExact("11/06/2009", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Hughes", LastName = "Callum", Email = "parturient.montes@enimSuspendisse.ca", BirthDate = DateTime.ParseExact("22/08/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Richard", LastName = "Quentin", Email = "malesuada.id.erat@fringillaeuismod.co.uk", BirthDate = DateTime.ParseExact("14/02/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Sims", LastName = "Giselle", Email = "tellus.faucibus@nullaIn.org", BirthDate = DateTime.ParseExact("06/01/2002", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Cross", LastName = "Whilemina", Email = "ut.ipsum.ac@InfaucibusMorbi.ca", BirthDate = DateTime.ParseExact("09/03/2006", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Carver", LastName = "Leo", Email = "non.justo.Proin@penatibusetmagnis.edu", BirthDate = DateTime.ParseExact("23/09/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Price", LastName = "Lara", Email = "posuere@maurisidsapien.edu", BirthDate = DateTime.ParseExact("24/03/2004", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Gutierrez", LastName = "Cole", Email = "Nunc.mauris.sapien@Inatpede.org", BirthDate = DateTime.ParseExact("19/06/2010", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Serrano", LastName = "Odette", Email = "Mauris.ut.quam@ac.org", BirthDate = DateTime.ParseExact("05/03/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Hyde", LastName = "Nigel", Email = "neque.sed@Pellentesque.co.uk", BirthDate = DateTime.ParseExact("15/01/2001", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Reilly", LastName = "Philip", Email = "ac.mattis@Curabitur.com", BirthDate = DateTime.ParseExact("23/03/2001", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Chaney", LastName = "Timon", Email = "in.consectetuer@sedsem.org", BirthDate = DateTime.ParseExact("16/11/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Conner", LastName = "Stewart", Email = "mus@vulputateveliteu.co.uk", BirthDate = DateTime.ParseExact("23/08/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Marshall", LastName = "Quin", Email = "nisl.sem.consequat@disparturientmontes.com", BirthDate = DateTime.ParseExact("11/03/2005", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Lester", LastName = "Madeson", Email = "Phasellus@felisegetvarius.org", BirthDate = DateTime.ParseExact("17/12/2004", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Wilson", LastName = "Kevin", Email = "Nunc.ut@nuncsedlibero.ca", BirthDate = DateTime.ParseExact("29/10/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Mckenzie", LastName = "Henry", Email = "nunc.risus.varius@elementumloremut.net", BirthDate = DateTime.ParseExact("17/06/2004", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Butler", LastName = "Adara", Email = "erat.vel@eleifend.com", BirthDate = DateTime.ParseExact("09/04/2015", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Harris", LastName = "Carissa", Email = "nec@ornare.com", BirthDate = DateTime.ParseExact("22/12/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Burt", LastName = "Caldwell", Email = "adipiscing.enim@magna.ca", BirthDate = DateTime.ParseExact("29/05/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Farrell", LastName = "Hedley", Email = "id.blandit@velit.co.uk", BirthDate = DateTime.ParseExact("25/06/2012", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Orr", LastName = "Knox", Email = "mi.tempor.lorem@nuncid.ca", BirthDate = DateTime.ParseExact("27/04/2018", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Floyd", LastName = "Evangeline", Email = "nunc@vestibulum.com", BirthDate = DateTime.ParseExact("10/07/2007", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Patterson", LastName = "Aretha", Email = "inceptos@blanditcongueIn.org", BirthDate = DateTime.ParseExact("29/05/2011", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Hall", LastName = "Geraldine", Email = "nunc@tortordictumeu.ca", BirthDate = DateTime.ParseExact("02/09/2014", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Doyle", LastName = "Henry", Email = "justo.Praesent@infaucibusorci.co.uk", BirthDate = DateTime.ParseExact("01/01/2004", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Hawkins", LastName = "Macon", Email = "aptent.taciti.sociosqu@atlacus.net", BirthDate = DateTime.ParseExact("27/04/2008", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Wolf", LastName = "Maya", Email = "accumsan.neque.et@nullaInteger.edu", BirthDate = DateTime.ParseExact("22/04/2005", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Mcgee", LastName = "Henry", Email = "ipsum.non.arcu@nibh.ca", BirthDate = DateTime.ParseExact("16/10/2015", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Vasquez", LastName = "Lara", Email = "sodales@tortorNunc.ca", BirthDate = DateTime.ParseExact("04/04/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Bernard", LastName = "Olympia", Email = "Etiam.imperdiet@dapibusgravida.co.uk", BirthDate = DateTime.ParseExact("08/02/2001", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Franklin", LastName = "Ariana", Email = "dui.lectus.rutrum@egetvolutpatornare.edu", BirthDate = DateTime.ParseExact("15/08/2005", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Good", LastName = "Tashya", Email = "eu@adipiscingMauris.org", BirthDate = DateTime.ParseExact("18/06/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Garza", LastName = "James", Email = "rhoncus.id@ipsumCurabiturconsequat.co.uk", BirthDate = DateTime.ParseExact("05/06/2004", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Mercer", LastName = "Athena", Email = "at@quisurna.org", BirthDate = DateTime.ParseExact("28/08/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Day", LastName = "Asher", Email = "congue.turpis@risusvarius.ca", BirthDate = DateTime.ParseExact("27/10/2008", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Black", LastName = "Aquila", Email = "neque@Crasegetnisi.net", BirthDate = DateTime.ParseExact("12/10/2004", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Gay", LastName = "James", Email = "convallis@egestasDuisac.co.uk", BirthDate = DateTime.ParseExact("29/06/2011", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Booker", LastName = "Jolie", Email = "dolor@aliquet.org", BirthDate = DateTime.ParseExact("07/06/2005", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Stark", LastName = "Karen", Email = "lobortis.ultrices@ac.com", BirthDate = DateTime.ParseExact("14/04/2011", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Mccray", LastName = "Clayton", Email = "diam@gravidasit.co.uk", BirthDate = DateTime.ParseExact("29/11/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Charles", LastName = "Armando", Email = "at.pretium@adipiscinglacus.co.uk", BirthDate = DateTime.ParseExact("13/02/2011", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Norton", LastName = "Martina", Email = "ut.mi@nonenimcommodo.ca", BirthDate = DateTime.ParseExact("09/07/2001", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Ramos", LastName = "Kenyon", Email = "Donec@etarcuimperdiet.co.uk", BirthDate = DateTime.ParseExact("03/03/2004", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Collier", LastName = "Cecilia", Email = "In@augueut.net", BirthDate = DateTime.ParseExact("05/06/2011", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Mccall", LastName = "Lareina", Email = "lectus.Nullam.suscipit@sitametrisus.edu", BirthDate = DateTime.ParseExact("04/05/2009", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Norris", LastName = "Leroy", Email = "Nullam.feugiat.placerat@Nam.net", BirthDate = DateTime.ParseExact("21/05/2015", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Gentry", LastName = "Hakeem", Email = "commodo.at.libero@conubia.com", BirthDate = DateTime.ParseExact("29/10/2006", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Shannon", LastName = "Rashad", Email = "Mauris.ut@Integeraliquamadipiscing.edu", BirthDate = DateTime.ParseExact("30/09/2011", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Chaney", LastName = "Hyatt", Email = "ut@arcuNuncmauris.net", BirthDate = DateTime.ParseExact("03/11/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Boyd", LastName = "Martin", Email = "eget.nisi.dictum@feugiat.ca", BirthDate = DateTime.ParseExact("19/05/2014", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Daniel", LastName = "Hillary", Email = "arcu.ac@DonectinciduntDonec.com", BirthDate = DateTime.ParseExact("20/11/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Graves", LastName = "Patience", Email = "Nullam.vitae@tincidunt.edu", BirthDate = DateTime.ParseExact("02/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Villarreal", LastName = "Colleen", Email = "lectus@dolor.co.uk", BirthDate = DateTime.ParseExact("29/10/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Chambers", LastName = "Kamal", Email = "Cras.vehicula.aliquet@egestasAliquamnec.org", BirthDate = DateTime.ParseExact("15/11/2014", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Whitehead", LastName = "Evan", Email = "ante@Suspendisse.edu", BirthDate = DateTime.ParseExact("04/08/2010", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Wynn", LastName = "Jessica", Email = "lectus.rutrum@euismodet.org", BirthDate = DateTime.ParseExact("07/08/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Franks", LastName = "Leandra", Email = "nec.orci@consequatauctornunc.ca", BirthDate = DateTime.ParseExact("27/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Ellis", LastName = "Tallulah", Email = "bibendum@metus.com", BirthDate = DateTime.ParseExact("10/07/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Williamson", LastName = "Jillian", Email = "pede.Suspendisse@cubilia.org", BirthDate = DateTime.ParseExact("06/06/2001", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Bass", LastName = "Gray", Email = "sit.amet.orci@Donec.co.uk", BirthDate = DateTime.ParseExact("04/08/2011", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Huber", LastName = "Dahlia", Email = "quam@in.ca", BirthDate = DateTime.ParseExact("30/09/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Burgess", LastName = "Kermit", Email = "lobortis.quam@rutrum.net", BirthDate = DateTime.ParseExact("06/04/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Cherry", LastName = "Howard", Email = "mus.Donec@Donec.org", BirthDate = DateTime.ParseExact("12/05/2001", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "James", LastName = "Beverly", Email = "ligula.tortor@laciniamattis.edu", BirthDate = DateTime.ParseExact("10/08/2003", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Little", LastName = "Rama", Email = "Donec.feugiat@montes.net", BirthDate = DateTime.ParseExact("10/03/2001", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Washington", LastName = "Gay", Email = "Phasellus.dolor.elit@nislMaecenasmalesuada.edu", BirthDate = DateTime.ParseExact("28/11/2009", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Ortiz", LastName = "Teagan", Email = "ultricies.sem.magna@Morbinonsapien.com", BirthDate = DateTime.ParseExact("16/12/2013", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Sellers", LastName = "Chava", Email = "id.enim@non.com", BirthDate = DateTime.ParseExact("26/02/2013", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Solis", LastName = "Rhona", Email = "ante@magna.net", BirthDate = DateTime.ParseExact("04/06/2015", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Dunlap", LastName = "Erin", Email = "pede.Praesent.eu@fermentumrisus.edu", BirthDate = DateTime.ParseExact("27/10/2008", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Salazar", LastName = "Jessica", Email = "lorem@atiaculis.co.uk", BirthDate = DateTime.ParseExact("08/09/2005", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Ashley", LastName = "Maia", Email = "ac@ametorciUt.com", BirthDate = DateTime.ParseExact("13/05/2011", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Dorsey", LastName = "Alfonso", Email = "euismod.mauris@sapienCras.org", BirthDate = DateTime.ParseExact("08/02/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Mcclain", LastName = "Nasim", Email = "euismod.et@egestasFusce.co.uk", BirthDate = DateTime.ParseExact("17/10/2005", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Meadows", LastName = "Nasim", Email = "Sed.diam.lorem@risusDonecegestas.ca", BirthDate = DateTime.ParseExact("03/12/2006", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Key", LastName = "Donovan", Email = "lorem.ipsum@blanditmattis.edu", BirthDate = DateTime.ParseExact("06/02/2002", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Salas", LastName = "Myra", Email = "et.malesuada.fames@tempus.org", BirthDate = DateTime.ParseExact("07/10/2006", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Perkins", LastName = "Indira", Email = "non.cursus@enimnectempus.net", BirthDate = DateTime.ParseExact("22/07/2015", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Harvey", LastName = "Aphrodite", Email = "egestas.Aliquam@hendrerit.ca", BirthDate = DateTime.ParseExact("29/11/2015", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Pollard", LastName = "Cora", Email = "Proin.nisl.sem@Nullam.edu", BirthDate = DateTime.ParseExact("06/08/2017", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Wells", LastName = "Harlan", Email = "quis.accumsan.convallis@in.com", BirthDate = DateTime.ParseExact("28/03/2012", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Dodson", LastName = "Emma", Email = "interdum@mifringillami.net", BirthDate = DateTime.ParseExact("07/08/2005", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Larsen", LastName = "Keiko", Email = "accumsan@mi.edu", BirthDate = DateTime.ParseExact("04/11/2004", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Salinas", LastName = "Adam", Email = "eleifend.egestas.Sed@Aliquam.net", BirthDate = DateTime.ParseExact("10/06/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Thompson", LastName = "Marcia", Email = "Donec@scelerisqueloremipsum.net", BirthDate = DateTime.ParseExact("30/01/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Sanchez", LastName = "James", Email = "Quisque@primis.co.uk", BirthDate = DateTime.ParseExact("02/11/2008", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Robinson", LastName = "Zephania", Email = "convallis@vel.co.uk", BirthDate = DateTime.ParseExact("20/07/2016", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Mayer", LastName = "Melvin", Email = "tempor.augue.ac@eratsemper.com", BirthDate = DateTime.ParseExact("15/07/2014", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Mason", LastName = "Jeremy", Email = "laoreet.libero@commodohendrerit.ca", BirthDate = DateTime.ParseExact("13/03/2008", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Sanchez", LastName = "Jerry", Email = "Integer.sem@Nunc.com", BirthDate = DateTime.ParseExact("11/12/2006", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Donaldson", LastName = "Vielka", Email = "sapien.gravida.non@ornarefacilisis.net", BirthDate = DateTime.ParseExact("10/04/2005", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Stanton", LastName = "Michael", Email = "ac.facilisis@facilisisegetipsum.org", BirthDate = DateTime.ParseExact("23/07/2009", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Frank", LastName = "Quamar", Email = "sociis@Ut.net", BirthDate = DateTime.ParseExact("09/11/2015", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Mack", LastName = "Dustin", Email = "mattis.Integer.eu@Morbi.edu", BirthDate = DateTime.ParseExact("06/02/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Craig", LastName = "Hunter", Email = "est.Nunc@sempercursusInteger.net", BirthDate = DateTime.ParseExact("16/08/2009", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Burks", LastName = "Grady", Email = "pede.sagittis.augue@arcuetpede.org", BirthDate = DateTime.ParseExact("28/10/2007", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Mckinney", LastName = "Violet", Email = "mollis.Duis@ligulaAliquam.org", BirthDate = DateTime.ParseExact("30/04/2008", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Jensen", LastName = "Erin", Email = "Curabitur@Suspendisse.co.uk", BirthDate = DateTime.ParseExact("26/05/2009", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                new Student() { FirstName = "Burch", LastName = "Abel", Email = "libero@egestas.edu", BirthDate = DateTime.ParseExact("27/05/2012", "dd/MM/yyyy", CultureInfo.InvariantCulture) }
            };
            #endregion
            #region SUBJECTS
            List<Subject> subjects = new List<Subject>()
            {
                new Subject(){ Name = "Français"},
                new Subject(){ Name = "C#"},
                new Subject(){ Name = "Mathématiques"},
                new Subject(){ Name = "ASP.NET"},
                new Subject(){ Name = "Anglais"},
            };
            #endregion
            #region GROUPS
            List<Group> groups = new List<Group>()
            {

            };
            #endregion
            #region TEACHERS
            List<Teacher> teachers = new List<Teacher>()
            {

            };
            #endregion
            #region CLASSROOM
            List<Classroom> classrooms = new List<Classroom>()
            {
                new Classroom(){},
                new Classroom(){},
                new Classroom(){},
                new Classroom(){},
                new Classroom(){},
                new Classroom(){},
            };
            #endregion
            #region COURSES
            List<Course> courses = new List<Course>()
            {

            };
            #endregion
            #region GRADES
            List<Grade> grades = new List<Grade>()
            {

            };
            #endregion
            #region MISSING
            List<Missing> missings = new List<Missing>()
            {

            };
            #endregion
            context.Students.AddRange(students);
            context.Teachers.AddRange(teachers);
            context.Subjects.AddRange(subjects);
            context.Groups.AddRange(groups);
            context.Classrooms.AddRange(classrooms);
            context.Courses.AddRange(courses);
            context.Grades.AddRange(grades);
            context.Missings.AddRange(missings);
            context.SaveChanges();
            // V ajout de données de test de la base ici V
        }
    }
}
