
// Задача 1

        int[] GetArray() {
            int[] result = new int[10];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new Random().Next(100, 1000);
            }
            return result;
        }
        void PrintArray(int[] arr) {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
        }
        int CountEvenNumbers(int[] array) {
            int count = 0;

            for (int i = 0; i < array.Length; i++) {
                if (array[i] % 2 == 0)
                    count += 1;
            }
            return count;
        }
        var array = GetArray();
        PrintArray(array);
        var EvenCount = CountEvenNumbers(array);
        Console.WriteLine(EvenCount);
    
// Задача № 2





