﻿using UnityEngine;
using System.Collections;
using Cirrus.ARPG.World.Objects;
using Cirrus.ARPG.World.Objects.Characters;

namespace Cirrus.ARPG.Conditions
{

    public class SceneCondition : MonoBehaviour, ICondition
    {
        public virtual bool Verify()
        {
            return false;
        }

        public virtual bool Verify(BaseObject source)
        {
            return Verify();
        }

        public virtual bool Verify(BaseObject source, BaseObject target)
        {
            return Verify();
        }

        public virtual bool Verify(BaseObject source, Character target)
        {
            return Verify(source, target as BaseObject);
        }


        public virtual bool Verify(Character subj)
        {
            return Verify((BaseObject)subj);
        }


        public virtual bool Verify(Character source, Character target)
        {
            return Verify(source as BaseObject, target);
        }

        public virtual bool Verify(Character source, BaseObject target)
        {
            return Verify(source as BaseObject, target);
        }


        public virtual IConditionedState GetListenedState(BaseObject target)
        {
            return null;
        }


        // Attach no listener
        public virtual IConditionedState GetListenedState(World.Objects.Characters.Character target)
        {
            return null;
        }
    }
}
