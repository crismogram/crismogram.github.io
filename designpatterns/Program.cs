using System;
using DesignPatternsSingleton;

Thread t1 = new Thread(() => {
    UploadService.GetInstance(1);
});

Thread t2 = new Thread(() => {
    UploadService.GetInstance(2);
});

t1.Start();
t2.Start();

t1.Join();
t2.Join();