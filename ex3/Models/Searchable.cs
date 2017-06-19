﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchAlgorithmsLib;

namespace ex3.Models
{
    /// <summary>
    /// implement ISearchable - serach problem.
    /// </summary>
    /// <typeparam name="T">type of serach problem</typeparam>
    /// <typeparam name="T1">type of state</typeparam>
    class Searchable<T,T1> : ISearchable<T>
    {
        /// <summary>
        /// adapater - type of serach problem.
        /// </summary>
        private Adapter<T> adapter;

        /// <summary>
        /// constructor.
        /// </summary>
        /// <param name="objectAdapter">adapater</param>
        public Searchable(Adapter<T> objectAdapter)
        {
            this.adapter = objectAdapter;
        }

        /// <summary>
        /// get initial state - vertex.
        /// </summary>
        /// <returns>initial state</returns>
        public State<T> GetInitialState()
        {
            return this.adapter.GetIntialized();
        }

        /// <summary>
        /// get goal state - vertex.
        /// </summary>
        /// <returns>goal state</returns>
        public State<T> GetGoalState()
        {
            return this.adapter.GetGoal();
        }

        /// <summary>
        /// name of serach problem
        /// </summary>
        /// <returns>name</returns>
        public string GetName()
        {
            return this.adapter.GetName();
        }

        /// <summary>
        /// get all possible neighbors.
        /// </summary>
        /// <param name="s">state to check is neighbors</param>
        /// <returns>list of neighbors state - vertex </returns>
        public List<State<T>> GetAllPossibleStates(State<T> current)
        {
            return this.adapter.GetAllPossible(current);
        }

        /// <summary>
        /// get cost between neighbors.
        /// 0-no neighbor, Weight between two vertex
        /// </summary>
        /// <param name="v">one state - vertex</param>
        /// <param name="u">seconde state - vertex</param>
        /// <returns>distance between neighbors</returns>
        public double GetCostNeg(State<T> neg1, State<T> neg2)
        {
            return this.adapter.CostBetNeg(neg1, neg2);
        }

        /// <summary>
        /// update state.
        /// s.cameFrom = n; s.cost = n.cost + searchable.getDistanceNeg(n, s);
        /// </summary>
        /// <param name="current">state to update.</param>
        /// <param name="parent">came from - parent</param>
        public void UpdateState(State<T> current, State<T> parent)
        {
            this.adapter.UpdateParent(current, parent);
        }

        public State<T> getInitialState()
        {
            throw new NotImplementedException();
        }

        public State<T> getGoalState()
        {
            throw new NotImplementedException();
        }

        public List<State<T>> getAllPossibleStates(State<T> s)
        {
            throw new NotImplementedException();
        }

        public double getDistanceNeg(State<T> v, State<T> u)
        {
            throw new NotImplementedException();
        }

        public void updateState(State<T> current, State<T> parent)
        {
            throw new NotImplementedException();
        }
    }
}
