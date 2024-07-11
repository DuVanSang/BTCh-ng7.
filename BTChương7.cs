using System;
using System.Collections.Generic;
using System.Text;

class BTChương7
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        while (true)
        {
            Console.WriteLine("\nChọn chức năng:");
            Console.WriteLine("1. Thêm cặp khóa-giá trị vào từ điển");
            Console.WriteLine("2. Kiểm tra xem khóa có tồn tại trong từ điển hay không");
            Console.WriteLine("3. Truy xuất giá trị được liên kết với một khóa");
            Console.WriteLine("4. Hiển thị tất cả các cặp khóa-giá trị trong từ điển");
            Console.WriteLine("5. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddKeyValuePair(dictionary);
                    break;
                case "2":
                    CheckKeyExists(dictionary);
                    break;
                case "3":
                    GetValueByKey(dictionary);
                    break;
                case "4":
                    DisplayAll(dictionary);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }

    static void AddKeyValuePair(Dictionary<string, int> dictionary)
    {
        Console.Write("Nhập khóa: ");
        string key = Console.ReadLine();
        Console.Write("Nhập giá trị: ");
        int value = int.Parse(Console.ReadLine());

        if (!dictionary.ContainsKey(key))
        {
            dictionary.Add(key, value);
            Console.WriteLine($"Đã thêm cặp khóa-giá trị ({key}, {value}) vào từ điển.");
        }
        else
        {
            Console.WriteLine("Khóa đã tồn tại trong từ điển. Không thể thêm.");
        }
    }

    static void CheckKeyExists(Dictionary<string, int> dictionary)
    {
        Console.Write("Nhập khóa để kiểm tra: ");
        string key = Console.ReadLine();

        if (dictionary.ContainsKey(key))
        {
            Console.WriteLine($"Khóa '{key}' tồn tại trong từ điển.");
        }
        else
        {
            Console.WriteLine($"Khóa '{key}' không tồn tại trong từ điển.");
        }
    }

    static void GetValueByKey(Dictionary<string, int> dictionary)
    {
        Console.Write("Nhập khóa để truy xuất giá trị: ");
        string key = Console.ReadLine();

        if (dictionary.TryGetValue(key, out int value))
        {
            Console.WriteLine($"Giá trị liên kết với khóa '{key}' là: {value}");
        }
        else
        {
            Console.WriteLine($"Không thể truy xuất giá trị cho khóa '{key}'.");
        }
    }

    static void DisplayAll(Dictionary<string, int> dictionary)
    {
        Console.WriteLine("Tất cả các cặp khóa-giá trị trong từ điển:");
        foreach (KeyValuePair<string, int> kvp in dictionary)
        {
            Console.WriteLine($"Khóa: {kvp.Key}, Giá trị: {kvp.Value}");
        }
    }
}

