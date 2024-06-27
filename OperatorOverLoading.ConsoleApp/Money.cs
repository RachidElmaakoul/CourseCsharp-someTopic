using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverLoading.ConsoleApp
{
    internal class Money
    {

        private decimal _amount;
        public decimal Amount => _amount;


        public Money(decimal value)
        {
            this._amount = value;
        }

        public static Money operator +(Money M1, Money M2){

           var Value = M1._amount + M2._amount;
            return new Money(Value);
        }  
        public static Money operator -(Money M1, Money M2){

           var Value = M1._amount - M2._amount;
            return new Money(Value);
        } 
        public static bool operator <(Money M1, Money M2){

           return M1._amount < M2._amount;
        }  public static bool operator >(Money M1, Money M2){

           return M1._amount > M2._amount;
        }  public static bool operator <=(Money M1, Money M2){

           return M1._amount <= M2._amount;
        }  public static bool operator >=(Money M1, Money M2){

           return M1._amount >= M2._amount;
        } 
        public static Money operator ==(Money M1, Money M2){

           var Value = M1._amount + M2._amount;
            return new Money(Value);
        }  public static Money operator !=(Money M1, Money M2){

           var Value = M1._amount + M2._amount;
            return new Money(Value);
        } public static Money operator ++(Money M1){

           var Value = M1._amount ;
            return new Money(++Value);
        }  public static Money operator --(Money M1){

           var Value = M1._amount ;
            return new Money(--Value);
        }

    }
}
