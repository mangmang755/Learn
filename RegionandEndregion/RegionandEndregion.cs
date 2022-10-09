#region Member Field Declarations
int x;
double d;
#endregion
#pragma warning disable 8    // 取消编号 8 的警告（字段未使用的警告）
public class MyClass
{
    int neverUsedField;       // 编译整个 MyClass 类时不会发出警告
}
#pragma warning restore 8   // 恢复编号 8 的警告