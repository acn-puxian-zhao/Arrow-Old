﻿angular.module('resources.collectorSoaProxy', []);
angular.module('resources.collectorSoaProxy').factory('collectorSoaProxy', ['rresource', '$http', 'APPSETTING', function (rresource, $http, APPSETTING) {
    var factory = rresource('collectorSoa');

    //execute
    factory.soaPaging = function (index, itemCount, filter, successcb, failedcb) {
        var itemspage = (index - 1) * itemCount;
        var filterStr = "$top=" + itemCount + "&$skip=" + itemspage + filter + "&$count=true";
        return factory.odataQuery(filterStr, successcb, failedcb);

    };


    factory.getNoPaging = function (type,successcb) {
        $http({
            url: APPSETTING['serverUrl'] + '/api/CollectorSoa?ListType=' + type,
            method: 'GET'
        }).then(function (result) {
            successcb(result.data);
        }).catch(function (result) {
            alert(result.data);
        });
    };


    factory.GetInvoicesStatusData = function (successcb) {
        $http({
            url: APPSETTING['serverUrl'] + '/api/CollectorSoa/GetInvoicesStatusData',
            method: 'GET'
        }).then(function (result) {
            successcb(result.data);
        }).catch(function (result) {
            alert(result.data);
        });
    };

    factory.GetCustomerCommentStatusData = function (successcb) {
        $http({
            url: APPSETTING['serverUrl'] + '/api/CollectorSoa/GetCustomerCommentStatusData',
            method: 'GET'
        }).then(function (result) {
            successcb(result.data);
        }).catch(function (result) {
            alert(result.data);
        });
    };
    
    factory.SetInvoicesStatusData = function (successcb) {
        $http({
            url: APPSETTING['serverUrl'] + '/api/CollectorSoa/SetInvoicesStatusData',
            method: 'POST'
        }).then(function (result) {
            successcb(result.data);
        }).catch(function (result) {
            alert(result.data);
        });
    };
    factory.DelInvoicesStatusData = function (successcb) {
        $http({
            url: APPSETTING['serverUrl'] + '/api/CollectorSoa/DelInvoicesStatusData',
            method: 'POST'
        }).then(function (result) {
            successcb(result.data);
        }).catch(function (result) {
            alert(result.data);
        });
    };
    

    factory.batch = function (strcusnums,successcb) {
        $http({
            url: APPSETTING['serverUrl'] + '/api/CollectorSoa?Cusnums=' + strcusnums,
            method: 'POST'
        }).then(function (result) {
            successcb(result.data);
        }).catch(function (result) {
            alert(result.data);
        });
    };

    //save invoice comm
    factory.savecomm = function (invid,comm, successcb) {

        $http({
            url: APPSETTING['serverUrl'] + '/api/CollectorSoa?InvId=' + invid + '&Comm=' + comm,
            method: 'POST'
        }).then(function (result) {
            successcb(result.data);
        }).catch(function (result) {
            alert(result.data);
        });
    };
    
    //update work flow
    factory.wfchange = function (referenceNo, type, successcb) {

        $http({
            url: APPSETTING['serverUrl'] + '/api/CollectorSoa?referenceNo=' + referenceNo + "&type=" + type,
            method: 'POST'
        }).then(function (result) {
            successcb(result.data);
        }).catch(function (result) {
            alert(result.data);
        });
    };

    //save Special Notes
    factory.savenotes = function (cus, spnotes, successcb) {
        $http({
            url: APPSETTING['serverUrl'] + '/api/CollectorSoa?Cus=' + cus + '&SpNotes=' + spnotes,
            method: 'POST'
        }).then(function (result) {
            successcb(result.data);
        }).catch(function (result) {
            alert(result.data);
        });
    };

    //common : 1:SpecicalNotes;2:InvoiceNotes
    factory.savecommon = function (list, successcb) {
        $http({
            url: APPSETTING['serverUrl'] + '/api/CollectorSoa',
            method: 'POST',
            data: list
        }).then(function (result) {
            successcb(result.data);
        }).catch(function (result) {
            alert(result.data);
        });
    };

    factory.forContactor = function (customerCode, successcb, failedcb) {
        return factory.query({ CustNumFCon: customerCode }, successcb, failedcb);
    }

    factory.checkPermission = function (custs, successcb) {
        $http({
            url: APPSETTING['serverUrl'] + '/api/CollectorSoa?ColSoa=' + custs,
            method: 'Get'
        }).then(function (result) {
            successcb(result.data);
        }).catch(function (result) {
            alert(result.data);
        });
    };

    factory.getCommDateHistory = function (customerCode, siteUseId, successcb) {
        $http({
            url: APPSETTING['serverUrl'] + '/api/CollectorSoa/GetCommDateHistory?CustomerCode=' + customerCode + '&SiteUseId=' + siteUseId,
            method: 'Get'
        }).then(function (result) {
            successcb(result.data);
        }).catch(function (result) {
            alert(result.data);
        });
    };
    return factory;
} ]);
