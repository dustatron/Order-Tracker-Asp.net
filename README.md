# _Vendor and Order Tracker_

#### _This is a simple ASP.Net Code 2.2 MVC app that mimics an order tracking web app. | March 13th. 2020_

#### By _**Dusty McCord**_

## Description

This web app will allow a business to track their vender and the orders made by those venders.  

[create a .gitignore template for your os here](https://www.gitignore.io/)

## Setup/Installation Requirements

_Make sure you have [git version control](https://git-scm.com/downloads) installed on your computer._

1. Find the green 'Clone or Download' button and copy the link
2. Open terminal and type...

**Windows**
```sh 
cd desktop
```

 Mac & linux 
 ```sh
 cd ~/Desktop
 ```

 3. In terminal type '_git clone {link to repository}_ '

```sh
git clone https://github.com/dustatron/Order-Tracker-Asp.net
```

4. Navigate to the new folder that was created on your desk

5. Navigate the new folder by tpying:
```sh
cd Order-Tracker-Asp.net/OrderTracker
```
6. Run this command:
```sh
dotnet run
```


## Specs
### Behavior Driven Development Spec List

Behavoir | Input | Output
:---------:|:------:|:------:
User should navigate to home page and see a slash screen | '/' | show splash screen
User can add a new vender | click add vender, enter details | vender saved
User and view list of venders | click view venders | show list of all venders
User can click on vender to see vender details | click vender name | show all vender details
User can edit vender details | click edit vender | show edit vender view
User can update details and save them | enter new details and click save | details updated and redirected back to vender details view
User can add orders to vender | click add order | order form
User can add order details and save them | ad details for order and click save | shows order details there were entered
User can edit order details | click edit | show edit form for order details allow save
User should be able to click see all orders and see a list of all orders of all venders | click see all | show list of all current orders 



## Support 

_The software is provided as is. It might work as expected - or not. Just don't blame me._


## Built With

* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [.Net Core 2.2](https://dotnet.microsoft.com/download/dotnet-core/2.2)


### License

This project is licensed under the MIT License 

Copyright (c) 2020 **_Dusty McCord_**

