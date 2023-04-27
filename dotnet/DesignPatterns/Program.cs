// See https://aka.ms/new-console-template for more information

Thread t1 = new Thread(() => {
    var instance = UploadService.GetInstance(1);
});

Thread t2 = new Thread(() => {
    var instance = UploadService.GetInstance(2);
});

t1.Start();
t2.Start();

t1.Join();
t2.Join();

System.Console.WriteLine("Hello, World!");