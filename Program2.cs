
//Блок 1 (2)
class BankAccount
{
    private decimal _balance; //робимо private, бо це баланс рахунку і його не можна позволяти міняти напряму
    public string Owner;// робимо public, бо ззовні нормально знати, кому належить рахунок.
    public decimal Balance => _balance;// Balance робимо public, бо користувач має право подивитися баланс.
    public void Deposit(decimal amount) { _balance += amount; }// Його робимо public, бо користувач має мати можливість покласти гроші на рахунок.
    public void Withdraw(decimal amount) { _balance -= amount; }//Його теж робимо public, бо користувач має мати можливість зняти гроші.
    private void RecalculateInterest() { /* внутрішня логіка */ } // Користувач не має сам вручну запускати перерахунок відсотків.
}


