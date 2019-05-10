import React, { Component } from 'react';
import { AsyncStorage, Text, View, StyleSheet, Button } from 'react-native';
import api from '../services/api';
import { Input } from 'native-base';
import { TextInput } from 'react-native-gesture-handler';

class CadastrarProjeto extends Component {
    constructor(props) {
        super(props);
        this.state = {
            token: "",
            nome: "",
            descricao: "",
            temaid: "1"
        }
    }

    _BuscarTokem = async() => {
        const value = await AsyncStorage.getItem('userToken')
        if (value !== null) {
            this.setState({token: value})
        }
        this._CadastrarProjeto()
    }
    
    _CadastrarProjeto = async () =>{
        const resposta = await api.post
        (   
            'projetos',
            {
                nome: this.state.nome,
                descricao: this.state.descricao,
                temaid: this.state.temaid
            },
            {
                headers: {
                    'Authorization' : 'Bearer ' + (this.state.token)
                }
            }
        )
    }
    
    render() {
        return (
            <View style={styles.container}>
                <Text>Coé</Text>
                <TextInput
                    placeholder="Nome do projeto"
                    onChangeText={nome => this.setState({nome})}
                />
                <TextInput
                    placeholder="Descrição"
                    onChangeText={descricao => this.setState({descricao})}
                />
                <Button title="Cadastrar" onPress={this._BuscarTokem}/>
            </View>
        )
    }
}

export default CadastrarProjeto;

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'center',
    },
});