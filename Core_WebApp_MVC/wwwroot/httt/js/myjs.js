const url = "http://localhost:5077/api/Student";
let test;

// Cach 1:
async function getdata(url) {
    const options = {
        method: 'GET',
        headers: {
            "Content-Type": "application/json; charset=utf-8",
            "Access-Control-Allow-Origin": "*",
            "Access-Control-Allow-Methods": "PUT,GET,POST,DELETE,OPTIONS",
            "Access-Control-Allow-Headers": "Content-Type, Access-Control-Allow-Headers, Authorization, X-Requested-With, Origin, X-Auth-Token"
        }
    }
    const response = await fetch(url, options);
    var data = await response.json();
    test = data;
    console.log(data);
    show_table(data);
}
getdata(url);


async function adddata(data) {
    const options = {
        method: "POST",
        headers: {
            "Content-Type": "application/json; charset=utf-8",
            "Access-Control-Allow-Origin": '*',
            "Access-Control-Allow-Methods": 'PUT,GET,HEAD,POST,DELETE,OPTIONS'
        },
        body: JSON.stringify(data)
    }
    const response = await fetch(url, options);
    var data = await response.json();
    test = data;
    console.log(data);
    $('#addSinhVien').modal('hide');
    clear_all();
    show_table(data);
}


// Cach 2:
//async function getapi(url) {
//    try {
//        const response = await fetch(url);

//        if (!response.ok) {
//            throw new Error(`Error! status: ${response.status}`);
//            console.log(response.status);
//        }

//        const result = await response.json();
//        return result;
//    } catch (err) {
//        console.log(err);
//    }
//}

//getapi();

function show_table(arrs) {
    let tb_row = `<tr>
        <td>(1)</td>
        <td>(2)</td>
        <td>(3)</td>
        <td>(4)</td>
        <td>(5)</td>
        <td>(6)</td>
        </tr>`;

    arrs.forEach(function show(p) {
        tb_row += `<tr class="httt_row">
        <td>${p.msv} </td>
        <td>${p.lop}</td>
        <td>${p.khoavien}</td>
        <td>${p.cccd}</td>
        <td>${p.hodem} ${p.ten}</td>
        <td>${p.tuoi}</td>
        </tr>`;
    });

    // Setting innerHTML as tab variable
    document.getElementById("dsSinhVien").innerHTML = tb_row;
}

function clear_all() {
    document.querySelectorAll(".httt_row").forEach(el => el.remove());
}

function refresh_all() {
    show_table(test);
}

function save_sinhvien() {
    //var msv = document.getElementById("msv").value;
    //var lop = document.getElementById("lop").value;
    //var khoavien = document.getElementById("khoavien").value;
    //var cccd = document.getElementById("cccd").value;
    //var hodem = document.getElementById("hodem").value;
    //var ten = document.getElementById("ten").value;
    //var tuoi = document.getElementById("tuoi").value;

    var my_msv = $("#msv").val();
    var my_lop = $("#lop").val();
    var my_khoavien = $("#khoavien").val();
    var my_cccd = $("#cccd").val();
    var my_hodem = $("#hodem").val();
    var my_ten = $("#ten").val();
    var my_tuoi = $("#tuoi").val();

    var data = {
        "msv": my_msv,
        "lop": my_lop,
        "khoavien": my_khoavien,
        "cccd": my_cccd,
        "hodem": my_hodem,
        "ten": my_ten,
        "bietdanh": "",
        "email": "",
        "dienthoai": "",
        "tuoi": my_tuoi
    }

    adddata(data);
}
