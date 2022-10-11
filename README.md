# Итоговая работа по блоку "Выбор специализации"

# Задание: 

- Создать репозиторий на [Github](https://github.com/)
- Нарисовать блок - схему алгоритма задачи.
- Снабдить репозиторий офрмленным текстовым описанием решения.
- Написать программу решающую задачу. 
- Использовать контроль версии (минимум 3 - 4 коммита)

# **Задача:**

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте введения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


**Пример:**
```sh
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
```

# **Описание решения:**

- Объявляем массив. Длина массива задается с консоли (*size*);

- Заполняем вручную первый массив. Отображаем на экране заполненный первый массив;

- Объявляем значение длины символов. Задаем с консоли (*max_word_length*);

- Создаем метод (*Update_array*), в котором создаем массив равный по длинне заданному и запускаем цикл, в котором при соблюдении условий (Длина символов элемента <= заданному значению длинны) записываем элемент в новый массив и так по всей длине массива. После возвращаем итоговый результат в виде нового массива.

- Отображаем итоговый новый массив. 

