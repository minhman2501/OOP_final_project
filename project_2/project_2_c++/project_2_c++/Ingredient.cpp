#include <iostream>
#include <string>
#include <list>

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

class Milk : Ingredient {
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

class CoffeeBeans : Ingredient {
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


};