public class Human 
{
    #region Fields
    private string firstName = "";
    private string lastName = "";
    private int age = 0;
    protected bool hasRightHand = true;
    protected bool hasLeftHand = true;
    #endregion

    #region Properties

    public int Age
    {
        get
        {
            return age;
        }
    }

    public string FirstName
    {
        get
        {
            return firstName;
        }
    }

    public string LastName
    {
        get
        {
            return lastName;
        }
    }

    public string FullName
    {
        get
        {
            return lastName + " " + firstName;
        }
    }
    #endregion

    #region Constructors
    public Human()
    {}

    public Human(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }
    #endregion

    #region MethodOverrides
    public override string ToString()
    {
        return firstName + " " + lastName + " " + age + " Lefthand -> " + hasLeftHand + " Righthand ->" + hasRightHand;
    }
    #endregion

    #region Methods

    public bool IsValid()
    {
        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            return false;
        return true;
    }

    public bool IsAnAdult()
    {
        return age >= 18;
    }

    public int FullNameSize()
    {
        return firstName.Length + lastName.Length;
    }
    #endregion
}
