int[] arr = new int[8];
for(int i = 0; i < arr.Length; i++){
    arr[i] = new Random().Next(1, 11);
    System.Console.Write("["+arr[i]+"]"+" ");
}
