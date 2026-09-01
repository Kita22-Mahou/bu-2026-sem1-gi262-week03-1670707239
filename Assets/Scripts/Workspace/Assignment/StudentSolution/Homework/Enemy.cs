using UnityEngine;

namespace Assignment.StudentSolution
{
    public class Enemy : Entity
    {
        public int dmg;
        protected int aiLevel;

        public virtual void Attack(Entity target)
        {


        }

        protected virtual void Patrol() 
        { 
        
        }
    }
}
