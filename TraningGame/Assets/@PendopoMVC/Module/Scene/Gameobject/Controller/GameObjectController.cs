using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using Pendopo.TraningGame.Module.PointClick;
using Pendopo.TraningGame.Message;
using Pendopo.TraningGame.Utils.Data;
using Pendopo.TraningGame.Global.TextureDataCollection;
namespace Pendopo.TraningGame.Module.Object
{
    public class GameObjectController : ObjectController<GameObjectController,GameObjectModel,IGameObjectModel,GameObjectView>
    {
        TextureDataCollectionController textureDataCollectionController;
        public void Init(ObjectData data, GameObjectView view)
        {
            SetView(view);
            _view.data = data;
            _model.Setdata(data);
            _model.SetRigidBody(view.rb);
            SetRender(data);
        }

        private void SetRender(ObjectData data)
        {
            MaterialPropertyBlock propBlock = new MaterialPropertyBlock();
            propBlock.SetTexture("_BaseMap", textureDataCollectionController.GetRequestTexture(data.FlavorPackageTexture));
            _view.basePackage.SetPropertyBlock(propBlock);

            propBlock.SetTexture("_BaseMap", textureDataCollectionController.GetRequestTexture(data.BarCode));
            _view.mr_barCode.SetPropertyBlock(propBlock);

            propBlock.SetTexture("_BaseMap", textureDataCollectionController.GetRequestTexture(data.Berat));
            _view.mr_berat.SetPropertyBlock(propBlock);

            propBlock.SetTexture("_BaseMap", textureDataCollectionController.GetRequestTexture(data.Contact));
            _view.mr_contact.SetPropertyBlock(propBlock);

            propBlock.SetTexture("_BaseMap", textureDataCollectionController.GetRequestTexture(data.Expire));
            _view.mr_exp.SetPropertyBlock(propBlock);

            propBlock.SetTexture("_BaseMap", textureDataCollectionController.GetRequestTexture(data.KodeProduksi));
            _view.mr_kodeProduksi.SetPropertyBlock(propBlock);

            propBlock.SetTexture("_BaseMap", textureDataCollectionController.GetRequestTexture(data.KomposisiEng));
            _view.mr_komposisiEng.SetPropertyBlock(propBlock);

            propBlock.SetTexture("_BaseMap", textureDataCollectionController.GetRequestTexture(data.KomposisiInd));
            _view.mr_komposisiInd.SetPropertyBlock(propBlock);

            propBlock.SetTexture("_BaseMap", textureDataCollectionController.GetRequestTexture(data.LogoHalal));
            _view.mr_logoHalal.SetPropertyBlock(propBlock);

            propBlock.SetTexture("_BaseMap", textureDataCollectionController.GetRequestTexture(data.LogoPilihan));
            _view.mr_logoPilihan.SetPropertyBlock(propBlock);

            propBlock.SetTexture("_BaseMap", textureDataCollectionController.GetRequestTexture(data.RasaGambar));
            _view.mr_logoRasaBelakaang.SetPropertyBlock(propBlock);

            propBlock.SetTexture("_BaseMap", textureDataCollectionController.GetRequestTexture(data.RasaGambar));
            _view.mr_logoRasaDepan.SetPropertyBlock(propBlock);

            propBlock.SetTexture("_BaseMap", textureDataCollectionController.GetRequestTexture(data.LogoRecycle));
            _view.mr_logoRecycle.SetPropertyBlock(propBlock);

            propBlock.SetTexture("_BaseMap", textureDataCollectionController.GetRequestTexture(data.Rasa));
            _view.mr_namaRasaBelakang.SetPropertyBlock(propBlock);

            propBlock.SetTexture("_BaseMap", textureDataCollectionController.GetRequestTexture(data.Rasa));
            _view.mr_namaRasaDepan.SetPropertyBlock(propBlock);

            propBlock.SetTexture("_BaseMap", textureDataCollectionController.GetRequestTexture(data.NutritionFact));
            _view.mr_nutrisi.SetPropertyBlock(propBlock);

            propBlock.SetTexture("_BaseMap", textureDataCollectionController.GetRequestTexture(data.Peringatan));
            _view.mr_peringatan.SetPropertyBlock(propBlock);

            propBlock.SetTexture("_BaseMap", textureDataCollectionController.GetRequestTexture(data.QRCodeLogo));
            _view.mr_qrCode.SetPropertyBlock(propBlock);

            propBlock.SetTexture("_BaseMap", textureDataCollectionController.GetRequestTexture(data.Seal));
            _view.mr_seal.SetPropertyBlock(propBlock);

            propBlock.SetTexture("_BaseMap", textureDataCollectionController.GetRequestTexture(data.Sedotan));
            _view.mr_sedotan.SetPropertyBlock(propBlock);
        }

        public void RotateObject(RotateMessage _message)
        {    
            float swipeAngle = Mathf.Atan2(_message.rotateVector.y, _message.rotateVector.x) * Mathf.Rad2Deg;
            float rotationAmount = _message.rotateVector.magnitude * Time.deltaTime;
            Vector3 rotationAxis = Quaternion.Euler(0, 0, swipeAngle) * Vector3.up;
            _view.transform.Rotate(rotationAxis, rotationAmount,Space.World);
        }
        public void ResetRotation(ResetRotateMessage _mesage)
        {
            _view.transform.eulerAngles = Vector3.down * 30f;
        } 
        
        public void ResetRotation()
        {
            _view.transform.eulerAngles = Vector3.down * 30f;
        }
        public void SetupReturn()
        {
            _view.gameObject.SetActive(false);
            _view.transform.eulerAngles = Vector3.down * 30f;
        }
    }
}
