Module GeneralDeclaration
    Public cn As ADODB.Connection
    Public adoRS As ADODB.Recordset

    Sub DBConnection()
        'Note: The data source is the path of your database 
        cn = New ADODB.Connection           'you may change “Alex Pasion VBNET” folder with your own folder where your database is saved.
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DLSAU.accdb;Persist Security Info=False;"
        cn.Open()
    End Sub
End Module