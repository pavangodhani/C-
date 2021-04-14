using System;
using Xunit;

namespace GradeBook.Tests
{

    public delegate string WriteLogDelegate(string logMessage); //Systax of defining delegate... //work of delegate here is pointing to the function which return type and parameter type are string... //delegate give the ability to declare a variable that I can use like a method

    public class TypeTests
    {
        int count;

        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage; //create a log veriable which type is WriteLogDelegate and it's seems like a pointer... 

            // log = new WriteLogDelegate(ReturnMessage);// long way 
            log += ReturnMessage;
            log += IncrementCount; 

            var result = log("Hello !");

            // Assert.Equal("Hello !", result);
            Assert.Equal(3, count);
        }

        private string IncrementCount(string message)
        {
            count++;
            return message.ToLower();
        }
        private string ReturnMessage(string message)
        {
            count++;
            return message;
        }

        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int z)
        {
            z = 42;
        }

        private int GetInt()
        {
            return 3;
        }


        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name"); //ref keyword shows the we can not pass value copy of reference but we pass original ref of obj.

            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref InMemoryBook book, string name) // here ref key word shows that we can't pass the copy of object reference but we pass original reference of that object
        {
            book = new InMemoryBook(name); //here book1 and book both refer same object.
        }

        // OUT is alternative of ref keyword but in OUT code assumed that incoming reference is not been initialized so it will be an error if you do not assign to an out parameter... 

        [Fact]
        public void CSharpPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(InMemoryBook book, string name)
        {
            book = new InMemoryBook(name); //here book1 and book both refer diff objects.
        }

        [Fact]

        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(InMemoryBook book, string name) //Its work like same below its coping the reference of book1 and its pass to the function here now both book and book1 refer the same obj.
        {
            book.Name = name;
        }

        [Fact]
        public void StringBehaveLikeValueTypes()
        {
            String name = "Marshal"; //strings are reference type is C#... and also strings are immutable...
            var upper = MakesUpperCase(name);

            Assert.Equal("Marshal", name);
            Assert.Equal("MARSHAL", upper);

        }

        private String MakesUpperCase(string name)
        {
            return name.ToUpper(); //all methods of string are not affected on original string its create a copy of that string...
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name); // Assert.Equal is match the values 
        }

        [Fact] //xUnit uses the [Fact] attribute to denote a parameterless unit test, which tests invariants in your code.

        public void TwoVarsReferenceSameObj()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1; // Is not making a copy of book1 this line will do is copy the pointer value of book1 so book1 and book2 both now refer the same obj

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 1", book2.Name);

            Assert.Same(book1, book2); //Assert.Same is metch the both variables refer the same obj or not

            Assert.True(Object.ReferenceEquals(book1, book2)); //Object.ReferenceEquals() is method of Object class which return bool value after check the both vars are refer a same obj or not
        }

        private InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}
