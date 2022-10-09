//#define DEBUG
//#define RELEASE
#if DEBUG && RELEASE
#error "You've defined DEBUG and RELEASE simultaneously!"  
#endif  
#warning "Don't forget to remove this line before the boss tests the code!"  
Console.WriteLine("*I hate this job.*");