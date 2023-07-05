//იქმნება Person ტიპის სამელემენტიანი მასივი personArray
//იქმნება Home ტიპის firstHome ობიექტი, რომლის კონსტრუქტორში გადაეცემა ორი პარამატრი "Address1" და "Belgrade"
//იქმნება Person ტიპის firstPerson ობიექტი, რომლის კონსტრუქტორში გადაეცემა ოთხი პარამატრი "Novak", 36, "131415" და firstHome ობიექტი
//personArray მასივის პირველ ელემენტს ენიჭება firstPerson ობიექტი
//იქმნება Home ტიპის secondHome ობიექტი, რომლის კონსტრუქტორში გადაეცემა ორი პარამატრი "Address2" და "Tbilisi"
//იქმნება Person ტიპის secondPerson ობიექტი, რომლის კონსტრუქტორში გადაეცემა ოთხი პარამატრი "Khvicha", 22, "123456" და secondHome ობიექტი
//მასივის მეორე ელემენტს ენიჭება secondPerson ობიექტი
//იქმნება Home ტიპის thirdHome ობიექტი, რომლის კონსტრუქტორში გადაეცემა ორი პარამატრი "Address3" და "Argentina"
//იქმნება Person ტიპის thirdPerson ობიექტი, რომლის კონსტრუქტორში გადაეცემა ოთხი პარამატრი "Lionel", 35, "101112" და thirdHome
//მასივის მესამე ელემენტს ენიჭება thirdPerson ობიექტი

Person[] personArray = new Person[3];
Home firstHome = new Home("Address1", "Belgrade");
Person firstPerson = new Person("Novak", 36, "131415", firstHome);
personArray[0] = firstPerson;
Home secondHome = new Home("Address2", "Tbilisi");
Person secondPerson = new Person("Khvicha", 22, "123456", secondHome);
personArray[1] = secondPerson;
Home thirdHome = new Home("Address3", "Argentina");
Person thirdPerson = new Person("Lionel", 35, "101112", thirdHome);
personArray[2] = thirdPerson;