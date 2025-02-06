using System;
using System.Collections.Generic;

public class GFG{

static class employee{
	public string name;
	public long code;
	public string designation;
	public int exp;
	public int age;
}

static int num;
static int max = 20;
static employee[] emp = new employee[max];
static employee[] tempemp = new employee[max];
static employee[] sortemp = new employee[max];
static employee[] sortemp1 = new employee[max];
static Scanner sc = new Scanner(System.in); 
static void build()
{
	Console.WriteLine("Build The Table\n");
	Console.WriteLine("Maximum Entries can be " + max);

	Console.WriteLine("Enter the number of " + "Entries required");


	num = sc.nextInt();

	if (num > 20) {
	Console.WriteLine("Maximum number of "+"Entries are 20");
	num = 20;
	}
	Console.WriteLine("Enter the following data:");

	for (int i = 0; i < num; i++) {
	Console.Write("Name ");
	emp[i].name = sc.next();

	Console.Write("Employee ID ");
	emp[i].code = sc.nextLong();

	Console.Write("Designation ");
	emp[i].designation = sc.next();

	Console.Write("Experience ");
	emp[i].exp = sc.nextInt();

	Console.Write("Age ");
	emp[i].age = sc.nextInt();
	}

	showMenu();
}

static void insert()
{
	if (num < max) {
	int i = num;
	num++;

	Console.Write("Enter the information " + "of the Employee");
	Console.Write("Name ");
	emp[i].name = sc.next();

	Console.Write("Employee ID ");
	emp[i].code = sc.nextLong();

	Console.Write("Designation ");
	emp[i].designation = sc.next();

	Console.Write("Experience ");
	emp[i].exp = sc.nextInt();

	Console.Write("Age ");
	emp[i].age = sc.nextInt();
	}
	else {
	Console.WriteLine("Employee Table Full");
	}

	showMenu();
}

static void deleteIndex(int i)
{
	for (int j = i; j < num - 1; j++) {
	emp[j].name = emp[j + 1].name;
	emp[j].code = emp[j + 1].code;
	emp[j].designation = emp[j + 1].designation;
	emp[j].exp = emp[j + 1].exp;
	emp[j].age = emp[j + 1].age;
	}
	return;
}

static void deleteRecord()
{
	Console.WriteLine("Enter the Employee ID "+ "to Delete Record");

	int code = sc.nextInt();


	for (int i = 0; i < num; i++) {
	if (emp[i].code == code) {
		deleteIndex(i);
		num--;
		break;
	}
	}
	showMenu();
}

static void searchRecord()
{
	Console.WriteLine("Enter the Employee"+" ID to Search Record");

	int code = sc.nextInt();

	for (int i = 0; i < num; i++) {

	if (emp[i].code == code) {
		Console.WriteLine("Name " + emp[i].name);

		Console.WriteLine("Employee ID " + emp[i].code);

		Console.WriteLine("Designation " + emp[i].designation);

		Console.WriteLine("Experience " + emp[i].exp);

		Console.WriteLine("Age " + emp[i].age);
		break;
	}
	}

	showMenu();
}

static void showMenu()
{

	Console.WriteLine("-------------------------"
					+ "GeeksforGeeks Employee"
					+ " Management System"
					+ "-------------------------\n");

	Console.WriteLine("Available Options:\n");
	Console.Write("Build Table		 (1)\n");
	Console.Write("Insert New Entry (2)\n");
	Console.Write("Delete Entry	 (3)\n");
	Console.Write("Search a Record	 (4)\n");
	Console.Write("Exit			 (5)\n");

	int option = sc.nextInt();

	if (option == 1) {
	build();
	}
	else if (option == 2) {
	insert();
	}
	else if (option == 3) {
	deleteRecord();
	}
	else if (option == 4) {
	searchRecord();
	}
	else if (option == 5) {
	return;
	}
	else {
	Console.WriteLine("Expected Options" + " are 1/2/3/4/5");
	showMenu();
	}
}

static public void Main (){
	showMenu();
}