
import {Component} from "react";

export default class Form extends Component{
    render() 
    {
        return <div>
            <form className='form' action="http://localhost:3000/ClientController/GetClient" method='post'>
                <p>ФИО:</p>
                <input name='fullname' placeholder='ФИО'/>
                <div>
                    <p>Паспорт</p>
                    <input name='passportSeries' required min={1000}  max={9999} placeholder='Серия'/>
                    <input name='passportNumber' required min={100000} max={999999}  placeholder='Номер'/>
                    <input name='passportGiven' required min={2} max={50} placeholder='Кем выдан'/>
                    <input name='passportGivenDate'  placeholder='Дата выдачи' type='date'/>
                    <input name='passportRegistration' required min={1} max={100} placeholder='Прописка'/>
                </div>
                <p>Возраст:</p>
                <input required max={120} name='age' type='number' placeholder='Возраст'/>
                <p>Судимость:</p>
                <input name='criminalRecord' type='checkbox'/>
                <p>Сумма кредита:</p>
                <input required max={1000000000000} name='sum' type='number' step='0.01' placeholder='Сумма кредита'/>
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
                    <option value='3'>Трудовой договор</option>
                    <option value='4'>Фриланс</option>
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
                <p>Если залог автомобиль, то сколько лет автомобилю :</p>
                <input required max={20} type='number' name='autoAge'/>
                <input type='submit' value='Получить кредит'/>
            </form>
        </div>
    }
}