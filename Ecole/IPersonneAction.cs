using System;
using System.Collections.Generic;

namespace Ecole
{
    interface IPersonneAction
    {
        void RentrerSalle(Salle _salle);
        void QuitterSalle(Salle _salle);

        String afficherPersonne();
    }
}