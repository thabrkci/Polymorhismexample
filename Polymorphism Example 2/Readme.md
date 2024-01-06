Herkese selam kısaca program şu şekilde;
bodyBuild sınıfı: Temel vücut geliştirme eylemini temsil eden bir sınıftır. lifttheWeight adlı sanal bir metot içerir.
Chest sınıfı: bodyBuild sınıfından türetilmiştir ve lifttheWeight metodunu geçersiz kılar (override). Göğüs kasları için özel bir aksiyon içerir.
Shoulder sınıfı: bodyBuild sınıfından türetilmiştir ve lifttheWeight metodunu geçersiz kılar (override). Omuz kasları için özel bir aksiyon içerir.
Main metodu: Programın başlangıcını temsil eder. İki örnek oluşturularak, her biri kendi lifttheWeight metodunu çağırır. Bu, polimorfizmin bir örneğidir.
--------------------------------------------------------
Hello everyone, briefly the program is as follows;
bodyBuild class: It is a class that represents the basic bodybuilding action. It contains a virtual method called lifttheWeight.
Chest class: derived from the bodyBuild class and overrides the lifttheWeight method. It contains a special action for the pectoral muscles.
Shoulder class: derives from the bodyBuild class and overrides the lifttheWeight method. Contains a special action for the shoulder muscles.
Main method: Represents the start of the program. Two instances are created, each calling its own lifttheWeight method. This is an example of polymorphism.
