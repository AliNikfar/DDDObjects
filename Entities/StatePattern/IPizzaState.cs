﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDObjects.Entities.StatePattern
{
    /// <summary>
    /// Good Implementation
    /// </summary>
    /// 
    //using this implement for true implementation without need to implement a lot of classes
    // should implement and type code as much as we need no more code.
    public abstract class Pizza2
    {

    }
    public sealed class OrderPizza2 : Pizza2
    {
        CookPizza2 GetOrder()
        {
            return new CookPizza2();
        }

    }

    public sealed class CookPizza2 : Pizza2
    {
        DeliveryPizza2 Cook()
        {
            return new DeliveryPizza2();
        }
    }
    public sealed class DeliveryPizza2 : Pizza2
    {

    }




    /// <summary>
    ///  Bad Implementation
    /// </summary>
    public interface IPizzaState
    {
        void GetOrder();
        void Cook();
        void Delivery();
    }

    public class Pizza
    {
        private readonly IPizzaState pizzaState;

        public Pizza(IPizzaState pizzaState)
        {
            this.pizzaState = pizzaState;
        }
        void GetOrder()
        { 
            pizzaState.GetOrder();
        }
        void Cook()
        {
            pizzaState.Cook();
        }

        void Delivery()
        { 
            pizzaState?.Delivery();
        }
    }

    public class PizzaGetOrderState : IPizzaState
    {
        public void Cook()
        {
            throw new Exception("pizza on Order State");
        }

        public void Delivery()
        {
            throw new Exception("pizza on Order State");
        }

        public void GetOrder()
        {
            Console.WriteLine("allow get order");
        }
    }
    public class PizzaCookState : IPizzaState
    {
        public void Cook()
        {
            Console.WriteLine("allow to cook");
        }

        public void Delivery()
        {
            throw new Exception("pizza on Cook State");
        }

        public void GetOrder()
        {
            throw new Exception("pizza on Cook State");
        }
    }
    public class PizzaDeliveryState : IPizzaState
    {
        public void Cook()
        {
            throw new Exception("pizza on Delivery State");
        }

        public void Delivery()
        {
            Console.WriteLine("allow to delivery");
        }

        public void GetOrder()
        {
            throw new Exception("pizza on Delivery State");
        }
    }
}
