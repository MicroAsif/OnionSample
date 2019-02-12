/// <reference path="C:\dev\OnionSample\OnionSample\Onion.Web\scripts/angular.js" />


app.controller("MedicineController", ["$scope", "MedicineService", "$modal",
    function ($scope, medicineService, $modal) {
        $scope.btnText = "Save";
        var baseUrl = '/api/Medicine/';
        $scope.GetCompanies =function() {
            var url = '/api/Company';
            var request = medicineService.getAllCompany(url);
            request.then(function (response) {
                console.log(response.data);
                $scope.Companies = response.data;
            });
        }

        $scope.GetCompanies();

        $scope.GetById = function (id) {
            var request = medicineService.getMedicineById(baseUrl, id);
            request.then(function(response) {
                $scope.Name = response.data.Name;
                $scope.Group = response.data.Group;
                $scope.Volume = response.data.Volume;
                $scope.CompanyId = response.data.CompanyId;
                $scope.btnText = "Update";
            });
        }

        $scope.GetMedicines = function() {
            var apiRoute = baseUrl ;
            var request = medicineService.getAll(apiRoute);
            request.then(function (response) {
                $scope.medicines = response.data;
            }, 
            function (error) {
                console.log("Error: " + error);
            });
        };
       
        $scope.GetMedicines();

        $scope.SaveUpdate = function() {
            var medicine = {
                Name: $scope.Name,
                Group: $scope.Group,
                Volume: $scope.Volume,
                CompanyId: parseInt($scope.CompanyId)
            };
            if ($scope.btnText === "Save") {
                var request = medicineService.post(baseUrl, medicine);
                request.then(function(response) {
                    if (response.data !== '') {
                        alert("Data Save Successfully");
                        $scope.GetMedicines();
                        $scope.Clear();
                    } else {
                        alert("Error");
                    }
                });
            }
            else {
                // update logic will be here
            }
            
        }

        $scope.Clear = function () {
            $scope.Name = "";
            $scope.Group = "";
            $scope.Volume = "";
            $scope.CompanyId = null;
            $scope.btnText = "Save";
        }

        $scope.askDelete = function (id) {
            var message = "Are you sure want to delete ?";

            var modalHtml = '<div class="modal-body">' + message + '</div>';
            modalHtml += '<div class="modal-footer"><button class="btn btn-danger" ng-click="ok()">OK</button><button class="btn btn-warning" ng-click="cancel()">Cancel</button></div>';

            var modalInstance = $modal.open({
                template: modalHtml,
                controller: ModalInstanceCtrl
            });

            modalInstance.result.then(function () {
                console.log("delete function will go here " + id);
                var url = baseUrl + id;
                var request = medicineService.delete(url);
                request.then(function (response) {
                    console.log(response.data);
                    if (response.data !== "") {
                        alert("Data Delete Successfully");
                        $scope.GetMedicines();
                        $scope.Clear();

                    } else {
                        alert("Some error");
                    }
                });
            });
        };
    }]);


var ModalInstanceCtrl = function ($scope, $modalInstance) {
    $scope.ok = function () {
        $modalInstance.close();
    };

    $scope.cancel = function () {
        $modalInstance.dismiss('cancel');
    };
};