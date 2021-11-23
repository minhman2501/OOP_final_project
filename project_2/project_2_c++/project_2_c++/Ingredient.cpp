#include <iostream>
#include <string>
#include <list>
#include <typeinfo>

using namespace std;
class Ingredient {
protected:
	string name;
	string unit;
	double amount;
	virtual string type() 
	{
		return NULL;
	};


public:
	Ingredient(string ingredient_BrandName, double ingredient_Amount, string ingredient_Unit)
	{
		this->name = ingredient_BrandName;
		this->unit = ingredient_Unit;
		this->amount = ingredient_Amount;
	}
	virtual void ingredient_Info()
	{
		cout << "Name:" << this->name << endl;
	}
	virtual void adding()
	{
		cout << this->type() + ": " << this->amount << this->unit << endl;
	}
	
};

class Milk : public Ingredient {
public:
	Milk(double ingredient_Amount) : Ingredient("Vinamilk", ingredient_Amount, "ml") {
	}
	void ingredient_Info()
	{
		Ingredient::ingredient_Info();
	}
	string type() {
		return "Milk";
	}
	void adding() {
		Ingredient::adding();
	}
};

class CoffeeBeans : public Ingredient {
protected:
	int _price;
	string name = Ingredient::name;
public:
	int price() {
		return _price;
	}
	CoffeeBeans(double ingredient_Amount) :Ingredient("", ingredient_Amount, "g") {};
	void adding() 
	{
		Ingredient::adding();
	}
};
class Robusta : CoffeeBeans {
protected:
	string type() {
		return "Robusta";
	}
public:
	Robusta(double ingredient_Amount) : CoffeeBeans(ingredient_Amount){
		this->_price = 3000;
		this->name = type();
	}
	void adding()
	{
		CoffeeBeans::adding();
	}

};
class Columbia : CoffeeBeans {
protected:
	string type() {
		return "Columbia";
	}
public:
	Columbia(double ingredient_Amount) : CoffeeBeans(ingredient_Amount) {
		this->_price = 5000;
		this->name = type();
	}
	void adding()
	{
		CoffeeBeans::adding();
	}
	


};

class Coffee {
protected:
	double cPrice;
	string name;
	list <Ingredient> iList;
	
	void addIngredients(Ingredient ing) {
		iList.push_back(ing);
	}
	virtual void addDefault() = 0;
	virtual void calcPrice() 
	{
		for(Ingredient ing : iList)
		{
			if (typeid(ing).name() == "CoffeeBeans")
			{
				CoffeeBeans bean = (CoffeeBeans)ing;
				cPrice += bean.price();
			}
		}
	}
public:
	int price() {
		return cPrice;
	}
	Coffee() {};

	Coffee(CoffeeBeans obj[]) {
		for (auto &bean : obj) {
			this->addIngredients(bean);
		}
	}
	void coffee_Info() {
		cout << "Name:" << name << endl;
		cout << "Price is:" << this->cPrice << "VND" << endl;
	}
	virtual void recipe() 
	{
		cout << "The Recipe of " << name << ":" << endl;
		for (Ingredient ing : iList)
		{
			ing.adding();
		}
	}
};

class CaPheSua : Coffee {
protected:
	void addDefault() {
		this->addIngredients(new Robusta(20));
		this->addIngredients(new Milk(20));
	}
public:
	CaPheSua() : Coffee()
	{
		name = "Nau Da";
		this->addDefault();
		this->calcPrice();
	}
	void calcPrice() {
		cPrice = 15000;
		Coffee::calcPrice();
	}
};
class CaPheDen : Coffee {
protected:
	void addDefault() {
		this->addIngredients(new Robusta(30));
	}
public:
	CaPheDen() : Coffee()
	{
		name = "Den Da";
		this->addDefault();
		this->calcPrice();
	}
	void calcPrice() {
		cPrice = 12000;
		Coffee::calcPrice();
	}
};
class BacXiu : Coffee {
protected:
	void addDefault() {
		this->addIngredients(new Robusta(20));
		this->addIngredients(new Milk(30));
	}
public:
	BacXiu() : Coffee()
	{
		name = "Bac Xiu";
		this->addDefault();
		this->calcPrice();
	}
	void calcPrice() {
		cPrice = 16000;
		Coffee::calcPrice();
	}
};
class Bill {
private:
	double total = 0;
	list <Coffee> cList;
public:
	double totalPrice() {
		return total;
	}
	void add();
	void billInput() 
	{
		cout << "How many drinks you want to order:";
		int count;
		int bean;
		int order;
		cin >> count; cout << endl;
		
		for (int i = 0; i < count; i++)
		{
			cout << "Choose your drink: \n1.Den Da\t 2.Nau Da\t 3.Bac Xiu" << endl;
			cin >> order;
			cout << endl;
			switch (order)
			{
			case 1:
				cout << "CoffeBeans:\n 1.Robusta\t 2.Columbia" << endl;
				cin >> bean; cout << endl;
				if (bean == 2)
				{
					this->add();
				}
				else this->add();
			case 2:
				cout << "CoffeBeans:\n 1.Robusta\t 2.Columbia" << endl;
				cin >> bean; cout << endl;
				if (bean == 2)
				{
					this->add();
				}
				else this->add();
			case 3:
				cout << "CoffeBeans:\n 1.Robusta\t 2.Columbia" << endl;
				cin >> bean; cout << endl;
				if (bean == 2)
				{
					this->add();
				}
				else this->add();
			}
			cout << "____________________" << endl;
		}
	}
	void billInfo()
	{
		cout << "BILL INFO" << "\n*******************" << endl;
		for (Coffee cf : cList)
		{
			cf.coffee_Info();
			total += cf.price();
			cout << "______________" << endl;
		}
		cout << "Total price:" << total << "VND" << endl;
	}
	void bill_calcPrice() {
		for (Coffee cf : cList)
		{
			total += cf.price();
		}
	}
};

static class CoffeeStore {
private:
	static double total;
	static list <Bill> bList;
	static list <Bill>::iterator it;
	static list <Coffee> cList;
	static int order;
	static void add_Drinks()
	{

	}
public:
	static void add_Bill() 
	{

	}
	static void orderCoffee() {
		
		cout << "Welcome to the Coffee Store!!!" << endl;
		while (true)
		{
			Bill bill;
			bill.billInput();
			add_Bill();
			
			cout << "Continue or Stop?:\n 1.Continue\t 2.Stop" << endl;
			cin >> order;
			cout << endl;
			if (order == 2) {
				bill.billInfo();
				break;
			}
		}
	}
	static void info() {
		cout << "Coffee Store All Bills" << "\n**************" << endl;
		order = 1;
		for (it = bList.begin();  it != bList.end(); it++)
		{
			cout << "Bill #" << order << ":" << endl;
			

		}
	}
};