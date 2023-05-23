namespace ToAspNetProject
{
    public class MarkDto
    {
        public string FullName { get; set; }
        public int Value { get; set; }
    }

    public class MarkReportPrintDto
    {
        public static MarkReportPrintDto Instanse { get; private set; } = new()
        {
            Id = 1,
            Date = DateTime.Now,
            StudyProgram = "Менеджмент туризму та гостинності",
            Specialization = "Економічна кібернетика",
            Semester = 2,
            GroupName = "НАТ-221",
            SubjectComponentTitle = "Математика",
            EmployeeSubjectName = "Кротяра Михаил Юславич",
            VeryfiEmployeeSubjectName = "Котяра Юсав Михаилич",
            UniversityDecan = "Припилько Анастасія Ананасівна",
            AnnualYear = 2023,
            Course = 1,
            StudyPlanId = 1,

            Marks = new List<MarkDto>()
            {
                new MarkDto{ FullName = "Губкин Феликс Эмануилович", Value = 100 },
                new MarkDto{ FullName = "Лупкина Эльвира Зигфридовна", Value = 90 },
                new MarkDto{ FullName = "Залупин Феликс Эмануилович", Value = 86 },
                new MarkDto{ FullName = "Комир Эльвира Зигфридовна", Value = 80 },
                new MarkDto{ FullName = "Вафлея Феликс Эмануилович", Value = 76 },
                new MarkDto{ FullName = "Фрем Феликс Эмануилович", Value = 66 },
                new MarkDto{ FullName = "Зонтик Феликс Эмануилович", Value = 59 },
                new MarkDto{ FullName = "Шибора Эльвира Зигфридовна", Value = 48 },
                new MarkDto{ FullName = "Головач Лена Зигфридовна", Value = 21 },
                new MarkDto{ FullName = "Красиво Эльвира Зигфридовна", Value = 10 },new MarkDto{ FullName = "Губкин Феликс Эмануилович", Value = 100 },
                new MarkDto{ FullName = "Лупкина Эльвира Зигфридовна", Value = 90 },
                new MarkDto{ FullName = "Залупин Феликс Эмануилович", Value = 86 },
                new MarkDto{ FullName = "Комир Эльвира Зигфридовна", Value = 80 },
                new MarkDto{ FullName = "Вафлея Феликс Эмануилович", Value = 76 },
                new MarkDto{ FullName = "Фрем Феликс Эмануилович", Value = 66 },
                new MarkDto{ FullName = "Зонтик Феликс Эмануилович", Value = 59 },
                new MarkDto{ FullName = "Шибора Эльвира Зигфридовна", Value = 48 },
                new MarkDto{ FullName = "Головач Лена Зигфридовна", Value = 21 },
                new MarkDto{ FullName = "Красиво Эльвира Зигфридовна", Value = 10 },new MarkDto{ FullName = "Губкин Феликс Эмануилович", Value = 100 },
                new MarkDto{ FullName = "Лупкина Эльвира Зигфридовна", Value = 90 },
                new MarkDto{ FullName = "Залупин Феликс Эмануилович", Value = 86 },
                new MarkDto{ FullName = "Комир Эльвира Зигфридовна", Value = 80 },
                new MarkDto{ FullName = "Вафлея Феликс Эмануилович", Value = 76 },
                new MarkDto{ FullName = "Фрем Феликс Эмануилович", Value = 66 },
                new MarkDto{ FullName = "Зонтик Феликс Эмануилович", Value = 59 },
                new MarkDto{ FullName = "Шибора Эльвира Зигфридовна", Value = 48 },
                new MarkDto{ FullName = "Головач Лена Зигфридовна", Value = 21 },
                new MarkDto{ FullName = "Красиво Эльвира Зигфридовна", Value = 10 },
            }
        };

        public int Id { get; set; }
        public DateTime Date { get; set; }

        public string Specialization { get; set; }

        public string StudyProgram { get; set; }

        public int Semester { get; set; }

        public string SubjectComponentTitle { get; set; }
        public string GroupName { get; set; }
        public string EmployeeSubjectName { get; set; }
        public string VeryfiEmployeeSubjectName { get; set; }
        public string UniversityDecan { get; set; }

        public int Course { get; set; }

        public int StudyPlanId { get; set; }
        public int AnnualYear { get; set; }
        public ICollection<MarkDto> Marks { get; set; }
    }
}
