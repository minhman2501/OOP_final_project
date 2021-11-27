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
class Robusta : public CoffeeBeans {
protected:
	string type() {
		return "Robusta";
	}
public:
	Robusta(double ingredient_Amount) : CoffeeBeans(ingredient_Amount){
		this->_price = 0;
		this->name = type();
	}
	void adding()
	{
		CoffeeBeans::adding();
	}

};
class Columbia : public CoffeeBeans {
protected:
	string type() {
		return "Columbia";
	}
public:
	Columbia(double ingredient_Amount) : CoffeeBeans(ingredient_Amount) 
	{
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
	list <Ingredient*> iList;
	
	void addIngredients(Ingredient* ing) {
		iList.push_back(ing);
	}
	virtual void addDefault() = 0;
	virtual void addMedium() = 0;
	virtual void calcPrice() 
	{
		for(Ingredient* ing : iList)
		{
			CoffeeBeans* bean = dynamic_cast<CoffeeBeans*>(ing);
			if (bean != NULL)
			{
				cPrice += bean->price();
			}
		}
	}
public:
	int price() {
		return cPrice;
	}
	Coffee() {};

	// Coffee(CoffeeBeans* obj[]) {
	Coffee(CoffeeBeans* beans) 
	{
		iList.push_back(beans);
	}
	void coffee_Info() {
		cout << "Name:" << name << endl;
		cout << "Price is:" << this->cPrice << "VND" << endl;
	}
	virtual void recipe() 
	{
		cout << "The Recipe of " << name << ":" << endl;
		for (Ingredient* ing : iList)
		{
			ing->adding();
		}
	}
	~Coffee()
	{
		for(auto ing : iList)
		{
			if(ing != NULL) delete ing;
		}
	}
};

class CaPheSua : public Coffee {
protected:
	void addDefault() 
	{
		this->addIngredients(new Milk(20));
	}
	void addMedium()
	{
		this->addIngredients(new Robusta(20));
		this->addIngredients(new Milk(20));
	}
public:
	CaPheSua() : Coffee()
	{
		name = "Nau Da";
		this->addMedium();
		this->calcPrice();
	}
	CaPheSua(CoffeeBeans* bean):Coffee(bean) 
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
class CaPheDen : public Coffee {
protected:
	void addDefault() {

	}
	void addMedium() {
		this->addIngredients(new Robusta(30));
	}
public:
	CaPheDen() : Coffee()
	{
		name = "Den Da";
		this->addMedium();
		this->calcPrice();
	}
	CaPheDen(CoffeeBeans* bean) :Coffee(bean)
	{
		name = "Den Da";
		this->calcPrice();
	}
	void calcPrice() {
		cPrice = 12000;
		Coffee::calcPrice();
	}
};
class BacXiu : public Coffee {
protected:
	void addDefault() {
		this->addIngredients(new Milk(30));
	}
	void addMedium() {
		this->addIngredients(new Robusta(10));
	}
public:
	BacXiu() : Coffee()
	{
		name = "Bac Xiu";
		this->addDefault();
		this->addMedium();
		this->calcPrice();
	}
	BacXiu(CoffeeBeans* bean) :Coffee(bean)
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
	list <Coffee*> cList;
public:
	double totalPrice() {
		return total;
	}
	Bill() {}
	Bill(list <Coffee*> coffeeList) {
		this->cList = coffeeList;
	}
	void add(Coffee* coffee) 
	{
		cList.push_back(coffee);
	}
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
					this->add(new CaPheDen(new Columbia(30)));
				}
				else this->add(new CaPheDen());
				break;
			case 2:
				cout << "CoffeBeans:\n 1.Robusta\t 2.Columbia" << endl;
				cin >> bean; cout << endl;
				if (bean == 2)
				{
					this->add(new CaPheSua(new Columbia(20)));
				}
				else this->add(new CaPheSua());
				break;
			case 3:
				cout << "CoffeBeans:\n 1.Robusta\t 2.Columbia" << endl;
				cin >> bean; cout << endl;
				if (bean == 2)
				{
					this->add(new BacXiu(new Columbia(10)));
				}
				else this->add(new BacXiu());
				break;
			}
			cout << "____________________" << endl;
		}
	}
	void billInfo()
	{
		cout << "BILL INFO" << "\n*******************" << endl;
		for (Coffee* cf : cList)
		{
			cf->coffee_Info();
			total += cf->price();
			cout << "______________" << endl;
		}
		cout << "Total price:" << total << "VND" << endl;
	}
	void bill_calcPrice() {
		for (Coffee* cf : cList)
		{
			total += cf->price();
		}
	}
	~Bill(){
		for (auto cf : cList)
		{
			if(cf != NULL) delete cf;
		}
	}
};

class CoffeeStore {
private:
	static double total;
	static list <Bill*> bList;
	static list <Coffee*> cList;
	static int order;
	static void add_Drinks()
	{
		cList.push_back(new BacXiu());
		cList.push_back(new CaPheDen());
		cList.push_back(new CaPheSua());
	}
public:
	static void add_Bill(Bill* bill) 
	{
		bList.push_back(bill);
	}
	static void orderCoffee() 
	{
		cout << "Welcome to the Coffee Store!!!" << endl;
		while (true)
		{
			Bill* bill = new Bill();
			bill->billInput();
			add_Bill(bill);
			
			cout << "Continue or Stop?:\n 1.Continue\t 2.Stop" << endl;
			cin >> order;
			cout << endl;
			if (order == 2) {
				info();
				break;
			}
		}
	}
	static void orderCoffee(list<Bill*> billList) 
	{
		bList = billList;
	}
	static void info()
	{
		cout << "Coffee Store All Bills" << "\n**************" << endl;
		for (Bill* bill : bList)
		{
			bill->billInfo();
			total += bill->totalPrice();
			cout << "______________" << endl;
		}
		cout << "Total Revenue:" << total << "VND";
	}
};

double CoffeeStore::total;
list <Bill*> CoffeeStore::bList;
list <Coffee*> CoffeeStore::cList;
int CoffeeStore::order;

int main() {
	BacXiu* bx1 = new BacXiu();
	CaPheDen* cfd = new CaPheDen();
	CaPheSua* cfs = new CaPheSua();

	CoffeeStore::orderCoffee();
}