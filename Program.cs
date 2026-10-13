// // // // int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// // // // int target = 1072;
// // // // bool found = false;

// // // // foreach (int number in recordBooks)
// // // // {
// // // //     if (number == target)
// // // //     {
// // // //         found = true;
// // // //         break;

// // // //     }
// // // // }

// // // // Console.WriteLine(found ? "Студент найден " : "Студент не найден");
// // // int variant = 2;
// // // bool isPrime = true;

// // // for (int divisor = 2; divisor < variant; divisor++)
// // // {
// // //     if (variant % divisor == 0)
// // //     {
// // //         isPrime = false;
// // //         break;
// // //     }
// // // }

// // // Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");

// // int[] pointsPerlab = { 8, -1, 10, 9, -1, 7 };
// // int sum = 0;
// // int count = 0;

// // foreach (int points in pointsPerlab)
// // {
// //     if (points < 0)
// //     {
// //         continue;
// //     }
// //     sum += points;
// //     count++;

// // }
// // Console.WriteLine($"Сумма баллов за сданные работы: {sum}");
// // Console.WriteLine(count);
// using System.Security.Principal;

// int[] groupsIds = { 101, 104, 107, 104, 110 };
// bool hasDuplicates = false;
// for (int i = 0; i < groupsIds.Length; i++)
// {
//     for (int j = i + 1; j < groupsIds.Length;)
//     {
//         if (groupsIds[i] == groupsIds[j])
//         {
//             hasDuplicates = true;
//             Console.WriteLine($"Найдены совпадающие номера : {groupsIds[i]} и {groupsIds[j]}");
//             break;
//         }
//     }
//     if (hasDuplicates)
//     {
//         break;
//     }
// }
// Console.WriteLine(hasDuplicates ? "есть повторяющиеся номера" : "все уникальные номера");