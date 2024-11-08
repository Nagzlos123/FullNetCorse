﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationOfObjects
{
    public class Price
    {
        public decimal Amount { get; }

        private Price(decimal amount)
        {
            Amount = amount;
        }

        public Price()
        {
            
        }

        public string GetValue(string pattern)
        {
            return string.Format(pattern, Amount);
        }

        public string GetValue()
        {
            return Amount.ToString();
        }
        public static Price Create(decimal amount) 
        { 
            return new Price(amount);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Price);
        }

        public bool Equals(Price other) 
        {
            if (ReferenceEquals(other, null)) 
            { 
                return false; 
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            return Amount == other.Amount;
        }

        public override int GetHashCode()
        {
            return Amount.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0:0.00}", Amount);
        }

        public static Price operator +(Price left, Price right) 
        {
            return Create(left.Amount + right.Amount);
        }

        public static Price operator -(Price left, Price right)
        {
            return Create(left.Amount - right.Amount);
        }

        public static Price operator *(Price left, Price right)
        {
            return Create(left.Amount * right.Amount);
        }
        public static Price operator /(Price left, Price right)
        {
            return Create(left.Amount / right.Amount);
        }

        public static bool operator ==(Price left, Price right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Price left, Price right)
        {
            return !Equals(left, right);
        }
    }
}
