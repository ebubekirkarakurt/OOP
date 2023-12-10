﻿Account account = new Account();
account.FirstName = "Ebubekir";
account.LastName = "Karakurt";

account.Deposit(700);
account.Withdraw(1900);
account.Withdraw(200);
account.AccountActivities();
account.CheckAccount();