//შექმენით კონსოლური აპლიკაცია, "საბანკო სევისები" -
//შექმენით partial კლასი BankAccount რომელსაც ექნება ფროფერთიები:
//AccountNumber - საბანკო ანგარიშის ნომერი;
//AccountHolderName - ანგარიშის მფლობელის დასახელება;
//Balance - ანგარიშზე არსებული ბალანსი. Balance ტიპი უნდა იყოს Struct Currency,
//რომელიც აღწერს ვალუტას და თანხას;
//და მეთოდები:
//Deposit(Currency amount) - ანგარიშზე თანხის შეტანა;
//Withdraw(Currency amount) - ანგარიშიდან თანხის გატანა;
//BalanceCheck - მიმდინარე ბალანსის შემოწმება, დააბრუნებს მიმდინარე ბალანსს;
//partial კლასის მეორე ნაწილში შექმენით მეთოდი TransferFunds(BankAccount target,
//Currency amount) რომელიც გადაცემულ ანგარიშზე გადარიცხავს მითითებულ სახსრებს.
//ამოცანაში უნდა გამოიყენოთ მინიმუმ 1 readonly field-ი.

using Task2;

BankAccount bank1 = new BankAccount("1", "nin", new Currency(500, " GEL"));
BankAccount bank2 = new BankAccount("2", "nin2", new Currency(200, " GEL"));
bank1.BalanceCheck();
bank1.Deposit(new Currency(100, " GEL"));
bank1.BalanceCheck();
bank1.Withdraw(new Currency(200, " GEL"));
bank1.BalanceCheck();
bank1.TransferFunds(bank2, new Currency(200, "  GEL"));
bank1.BalanceCheck();
