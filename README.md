# DynamoForceUpdater

Нод динамо для принудительного перезапуска цепочки последующих нодов в вашем скрипте.

![image](https://user-images.githubusercontent.com/68222448/168808031-0a3e50f2-8207-423e-b2c2-4a0a01cca2c9.png)


Сделан на основе нода ForceChildsEval (Prorubim) и данного обсуждения: 
https://forum.dynamobim.com/t/how-to-force-nodes-to-rerun-without-changes-when-nodes-rerun/56366/4?u=vladimir

Скопируйте содержимое папки Output, вставьте в папку, где расположены ваши пакеты.
В моем случае это папка: C:\Users\151\AppData\Roaming\Dynamo\Dynamo Revit\2.12\packages

Либо можно имортировать библиотеку DynamoForceUpdater.dll из папки Output напрямую в интерфейсе динамо
Работает только в 22 ревите, в 19 не работает. В других не тестировал

На вход этому ноду нужно обязательно что-то подавать, иначе ничего не произойдет
