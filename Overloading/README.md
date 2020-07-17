## WHAT EXACTLY IS OVERLOADING
It is when we have 1 method but has many different variations to it. We invoke each of the different variations all with the same name.
Say I have a method Test
```cs
User u = new User();
u.Test();//This will call the Test Method which takes no arguments
u.Test(16);//This will call the Test Method which takes 1 argument and has a parameter of type int
```
As you can see the method Test in Line 6 and Line 7 have the same name but not the same signature.
This is what is known as Overloading. Overloading a method can occur when we have the same method name but different number of parameters, same method name but 
different data type within my parameters. So we above we have 1 Test Method with two overloads.
When you want to have a function which you want to behave the same way for various data types we do that by creating overloaded functions.
OVERLOADS MUST HAVE THE SAME RETURN TYPES.

```cs
public int Test();
public string Test();
```

LINE 16 and LINE 17 ARE NOT OVERLOADS! As a matter of fact this will cause a compile time error


