
import {Component} from "react";

export default class Form extends Component{
    render()
    {
        return <div>
            <h1>Анкета</h1>
            <form action="http://localhost:5002/ClientController/GetCredit" method='post'>
                <p>ФИО:</p>
                <input name='fullname' placeholder='ФИО'/>
                <div>
                    <p>Паспорт</p>
                    <input name='passportSeries'  placeholder='Серия'/>
                    <input name='passportNumber'  placeholder='Номер'/>
                    <input name='passportGiven' placeholder='Кем выдан'/>
                    <input name='passportGivenDate' placeholder='Дата выдачи' type='date'/>
                    <input name='passportRegistration' placeholder='Прописка'/>
                </div>
                <p>Возраст:</p>
                <input name='age' type='number' placeholder='Возраст'/>
                <p>Судимость:</p>
                <input name='criminalRecord' type='checkbox'/>
                <p>Сумма кредита:</p>
                <input name='sum' type='number' step='0.01' placeholder='Сумма кредита'/>
                <p>Цель:</p>
                <select name='goal'>
                    <option value='1'>Потребительский кредит</option>
                    <option value='2'>Недвижимость</option>
                    <option value='3'>Перекредитование</option>
                </select>
                <p>Трудоустройство:</p>
                <select name='employment'>
                    <option value='1'>Безработный</option>
                    <option value='2'>ИП</option>
                    <option value='3'>Договор ТК РФ</option>
                    <option value='4'>Без договора</option>
                    <option value='5'>Пенсионер</option>
                </select>
                <p>Другие кредиты:</p>
                <input name='otherCredits' type='checkbox'/>
                <p>Залог:</p>
                <select name='pledge'>
                    <option value='1'>Недвижимость</option>
                    <option value='2'>Автомобиль</option>
                    <option value='3'>Поручительство</option>
                    <option value='4'>Без залога</option>
                </select>
                <p>Возраст авто в годах, если залог - авто:</p>
                <input type='number' name='autoAge'/>
                <input type='submit' value='Получить кредит'/>
            </form>
        </div>
    }
}