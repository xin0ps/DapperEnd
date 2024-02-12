using Microsoft.Data.SqlClient;
using Dapper;
using System.Data;

    
        string constr = "Data Source=LAPTOP-JLBUNNBV\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

SqlConnection sqlConnection = new SqlConnection(constr);
        
            sqlConnection.Open();

            string insertqueryAuthor = "INSERT INTO Authors(Id,FirstName, LastName) VALUES    (15,'Author1', 'Author1') , (16,'Author2', 'Author2') , (17,'Author3', 'Author3')";
            string deletequeryAuthor = "DELETE  FROM Authors WHERE Id Between 15 and 17";
            string updatequeryAuthor = "Update  Authors SET FirstName = 'Updated'  WHERE Id Between 15 and 17";





//sqlConnection.Execute(insertqueryAuthor);
//sqlConnection.Execute(deletequeryAuthor);
//sqlConnection.Execute(updatequeryAuthor);


