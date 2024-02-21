using System.Collections;
using System.Collections.Generic;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Utils.Data;
using UnityEngine;

namespace Pendopo.TraningGame.Module.PointClick
{
    public class PointClickController : ObjectController<PointClickController, PointClickModel, IPointClickModel, PointClickView>
    {
        private void OnClickCheck()
        {
            Publish<FocusObjectMessage>(_model.focusObjectMessage);
            Publish<CompareCheck>(_model.compareCheckMessagec);
        }

        public void init(PointClickModel _model, PointClickView _view,string _data)
        {
            this._model = _model;
            _model.SetData(_view.checkType,_data, new FocusObjectMessage { isContainer = _view.checkType== CheckType.Package, objectToFocus = _view.gameObject }, new CompareCheck { data = _data, type = _view.checkType });

            _view.SetCallback( OnClickCheck);
            _view.MatID = GetMaterial(_view.checkType);

            SetView(_view);
        }


        private int GetMaterial(CheckType _type)
        {
            for (int i = 0; i < _view.Mesh.sharedMaterials.Length; i++)
            {
                if(_view.Mesh.sharedMaterials[i].name == _type.ToString())
                {
                    return i;
                }
            }
            Debug.Log("No Match Material Name");
            return 0;
        }
    }
}