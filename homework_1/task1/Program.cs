// Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.

class Answer {
    public static void CompareNumbers(int number1, int number2) {
        if (number1 > number2) {
            System.out.println("Первое число больше второго: " + number1 + " > " + number2);
        } else if (number1 < number2) {
            System.out.println("Второе число больше первого: " + number2 + " > " + number1);
        } else {
            System.out.println("Числа равны: " + number1 + " = " + number2);