# ПРОГРАММА ВЫВОДА ДАННЫХ СТРОКОВОГО МАССИВА
# С ОГРАНИЧЕНИЕМ ПО КОЛИЧЕСТВУ СИМВОЛОВ

## **Задача**

Написать программу, которая из имеющегося массива строк  
формирует массив из строк, длина которых меньше либо равна  
3 символа. Первоначальный массив можно ввести с клавиатуры,  
либо задать на старте выполнения алгоритма. При решении не  
рекомендуется пользоваться коллекциями, лучше обойтись  
исключительно массивами.

## _**Примеры:**_

["hello","2","world",":-)"] -> ["2",":-)"]  
["1234","1567","-2","computer science"] -> ["-2"]  
["Russia","Denmark","Kazan"] -> []
______

## **Описание решения задачи**

Начало программы.  
Пользователю предлагается ввести набор строк через запятую.  
Из строки, введенной пользователем создается строковый массив.  
При помощи метода сравниваем длину каждого элемента массива  
с заданным ограничением и, если условие выполняется, выводим  
текущий элемент в консоль.  
Конец программы.