Module Globals
    Public User As Integer
    Public Login As Boolean = False
    Public Admin As Boolean = False
    Public WOProperty As Integer
    Public connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\db\Property_Manager.accdb"
    Public UsersTableAdapter As New Property_ManagerDataSetTableAdapters.UsersTableAdapter()
    Public PropertiesTableAdapter As New Property_ManagerDataSetTableAdapters.PropertiesTableAdapter()
    Public TenantsTableAdapter As New Property_ManagerDataSetTableAdapters.TenantsTableAdapter()
    Public PaymentsTableAdapter As New Property_ManagerDataSetTableAdapters.PaymentsTableAdapter()
    Public PaymentTypesTableAdapter As New Property_ManagerDataSetTableAdapters.PaymentTypesTableAdapter()
    Public VendorsTableAdapter As New Property_ManagerDataSetTableAdapters.VendorsTableAdapter()
    Public WorkOrdersTableAdapter As New Property_ManagerDataSetTableAdapters.WorkOrdersTableAdapter()
    Public EmployeesTableAdapter As New Property_ManagerDataSetTableAdapters.EmployeesTableAdapter()
    Public ChargesTableAdapter As New Property_ManagerDataSetTableAdapters.ChargesTableAdapter()

End Module


