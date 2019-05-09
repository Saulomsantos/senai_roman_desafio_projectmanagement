import React, { Component } from 'react';
import { Alert, AsyncStorage, Button, StyleSheet, Text, TextInput, TouchableOpacity, View } from 'react-native';

import api from './src/services/api';

import jwt from "jwt-decode";

import { createSwitchNavigator, createAppContainer, createDrawerNavigator } from 'react-navigation';

import HomeAdm from './src/pages/homeadm';
import GerenciarTipoUsuario from './src/pages/gerenciartipousuario';
import Equipes from './src/pages/equipes';
import GerenciarUsuarios from './src/pages/gerenciarusuarios';
import CadastrarUsuario from './src/pages/cadastrarusuario';
import Temas from './src/pages/temas';
import HomePro from './src/pages/homepro';
import GerenciarProjetos from './src/pages/gerenciarprojetos';
import CadastrarProjeto from './src/pages/cadastrarprojeto';
// import { TouchableOpacity } from 'react-native-gesture-handler';

class App extends Component {

    render() {
        return (
            <AppContainer />
        )
    }
}

export default App;

class TelaInicial extends Component {

    constructor(props) {
        super(props);
        this.state = { email : '', senha : '' };
    }

    _realizarLogin = async () => {

        const resposta = await api.post('/login', {
            email: this.state.email,
            senha: this.state.senha
        });

        const token = resposta.data.token;

        await AsyncStorage.setItem('userToken', token);

        const value = await AsyncStorage.getItem('userToken');

        if ( jwt(value).Role == 'ADMINISTRADOR' ) {
            this.props.navigation.navigate('Home - Administrador')            
        }
        else {
            if ( jwt(value).Role == 'PROFESSOR' ) {
                this.props.navigation.navigate('Home - Professor')            
            }
        }       

    }

    render() {
        return (
            <View style={styles.container}>
                <TextInput
                    placeholder="E-mail"
                    onChangeText={email => this.setState({ email })} 
                />

                <TextInput
                    placeholder="Senha"
                    onChangeText={senha => this.setState({ senha })} 
                />

                <TouchableOpacity
                    onPress={this._realizarLogin}
                >
                    <Text>LOGIN</Text>
                </TouchableOpacity>
            </View>
        )
    }
}

const ProDrawerNavigator = createDrawerNavigator({
    'Tela Inicial': { screen: TelaInicial },
    'Home - Professor': HomePro,
    'Gerenciar Projetos': GerenciarProjetos,
    'Cadastrar Projeto': CadastrarProjeto,
    Temas: Temas
},{
    initialRouteName: 'Home - Professor'
})

const AdmDrawerNavigator = createDrawerNavigator({
    'Tela Inicial': { screen: TelaInicial },
    'Home - Administrador': HomeAdm,
    'Gerenciar Tipo Usuario': GerenciarTipoUsuario,
    Equipes: Equipes,
    'Gerenciar Usuarios': GerenciarUsuarios,
    'Cadastrar Usuario': CadastrarUsuario,
    Temas: Temas
},{
    initialRouteName: 'Home - Administrador'
})

const AppSwitchNavigator = createSwitchNavigator({
    'Tela inicial': { screen: TelaInicial },
    'Home - Administrador': { screen: AdmDrawerNavigator },
    'Home - Professor': { screen: ProDrawerNavigator }
})

const AppContainer = createAppContainer(AppSwitchNavigator);

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'space-around',
    },
});