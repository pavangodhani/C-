namespace DelegateProj
{
    public delegate string GreetingDelegate(string name);
    class AnonymousMethods
    {
        public string Greetings(string name)
        {
            return "Hello " + name + " Good Morning!...";
        }

        GreetingDelegate greetingDelegate = delegate (string name) //Anonymous Methods...
        {
            return $"Hello {name} this is Anonymous Method....A method with out a name....it's contains only body and method define by using 'delegate' keyword....and no need to declair specifiers, return type....use this type of method declaration when code volume is lesser....";
        };

    }
}