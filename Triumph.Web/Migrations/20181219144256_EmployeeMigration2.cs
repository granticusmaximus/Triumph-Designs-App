using Microsoft.EntityFrameworkCore.Migrations;

namespace Triumph.Web.Migrations
{
    public partial class EmployeeMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Employees_AssignedEmpID",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Employees_AssignedEmpIDEmpID",
                table: "Todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "EmpID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Employee_AssignedEmpID",
                table: "Clients",
                column: "AssignedEmpID",
                principalTable: "Employee",
                principalColumn: "EmpID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Employee_AssignedEmpIDEmpID",
                table: "Todos",
                column: "AssignedEmpIDEmpID",
                principalTable: "Employee",
                principalColumn: "EmpID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Employee_AssignedEmpID",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Todos_Employee_AssignedEmpIDEmpID",
                table: "Todos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmpID");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Employees_AssignedEmpID",
                table: "Clients",
                column: "AssignedEmpID",
                principalTable: "Employees",
                principalColumn: "EmpID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Todos_Employees_AssignedEmpIDEmpID",
                table: "Todos",
                column: "AssignedEmpIDEmpID",
                principalTable: "Employees",
                principalColumn: "EmpID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
