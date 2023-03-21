# Программа "MyLoginAoo"
 Данная программа предназначена для авторизации пользователя.

Древо проекта:

![ProjectTree](/Images/ProjectTree.png "Древо проекта")


Интерфейсы приложения:

![LoginPage](/Images/LoginPage.png "Страница входа/регистрации")

![LoginPage2](/Images/LoginPage2.png "Страница входа/регистрации с введёнными данными")

![HomePage](/Images/HomePage.png "Страница после входа/регистрации")


![HomePage2](/Images/HomePage2.png "Страница после входа/регистрации с боковой панелью")

Описание класса **"UserInfo"**:
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLoginApp.Models
{
    public class UserInfo
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}

```

Описание класса **"Icon"**:
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLoginApp.Models
{
    public static class Icons
    {
        public const string Dashboard = "dashboard.png";
        public const string ContactUs = "contact_us.png";
        public const string AboutUs = "about_us.png";
        public const string People = "team.png";
    }
}
```
