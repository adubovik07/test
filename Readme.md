# *Задача:*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

# *Решение:*
Задать длинну массива и наполнить его значениями. Т.к массив будет состоять не из чисел, то задаем его через string. Затем выводим этот массив в терминал, чтобы можно было сопоставить исходный и результирующий массивы.
Создаем метод, в котором программа будет проходиться по исходному массиву и находить элементы, состоящие из 3-х и менее символов, а затем создаст новый массив, состоящий только их ткаих значений. это и будет результирующий массив.
Выводим новый массив, проверяем результат.