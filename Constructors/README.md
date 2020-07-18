Say I have a class called Teachers


```cs
Teacher wolesensky = new Teacher();
```

The Teacher method on the right is a constructor. A constructor name must match the name of the class.
We invoke a constructor by prefixing the new keyword followed by the name of the class.
A constructor has no return or return type.

Here is a solid example of a constructor
```cs
public class User{
    public User()
    {
    
    }
}
```

At the very top Teacher(); is what's known as the default constructor because it takes no parameters.
Remember if no constructor is defined within you class implementation it will be done implicitly.

To get initial values for an object we use what's called a custom constructor
Here is an example

```cs
public class Car{
	public Car(string x)
	{
		CarBrand = x;
	}

}
Car ford = new Car("Mustang");
```
All in all, just remember constructors allow you to instantiate a class into an object.
