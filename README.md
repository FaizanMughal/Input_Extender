# Input_Extender
Adds Double/Long Click functionality to your Mouse Button and Key press


## How to Use the Code

The Key_Extender and Mouse_Extender are located in the InputExtender namespace. So remember to include 

```csharp
using InputExtender
```

into your script.



Follow the same useage pattern as the Input Class

```csharp
        If(Input.GetMouseButton(0))
        {
            //do stuff
        }
```

So you would use: 

```csharp
        if (Mouse_Extender.IsLongClick(0))
        {
            //Long Mouse Click 
        }

        if (Mouse_Extender.IsDoubleClick(0))
        {
            //Double Mouse Click 
        }

        if (Key_Extender.IsLongKeyPress(KeyCode.J))
        {
            //Long Key Press
        }

        if (Key_Extender.IsDoublekeyPress(KeyCode.L))
        {
            //Double Key Press
        }
       
``` 


Key_Extender and Mouse_Extender are static classes. So there is no need to place them on a GameObject. 
